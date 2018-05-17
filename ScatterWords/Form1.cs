using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScatterWords
{
    public partial class Form1 : Form
    {
        // App info
        string appName      = "ScatterWords";
        string aboutText    = "Originally coded in a hurry by Kuig in 2017\nLast build: " + "2017-06-09";
        string aboutCaption = "About this crappy software...";

        // Fixed settings
        string txtFilter = "Text file (*.txt)|*.txt|Any file (*.*)|*.*";
        string swdFilter = "ScatterWords file (*.swd)|*.swd";
        char token = ',';

        int globalGridSize = 16;
        int labelPerColumn = 100;
        int columnSpacing  = 256;

        string fontName       = "Consolas";
        float bigFontSize     = 14.00f;
        float smallFontSize   = 08.25f;

        BorderStyle labelBorder =  BorderStyle.FixedSingle;
        Color labelBg  = Color.FromArgb(0xFF, 0x1E, 0x1E, 0x1E);
        Color labelFg  = Color.FromArgb(0xFF, 0xDC, 0xDC, 0xDC);
        Color SlabelBg = Color.FromArgb(0xFF, 0x0F, 0x0F, 0x0F);
        Color SlabelFg = Color.FromArgb(0xFF, 0x00, 0x7A, 0xCC);

        // Working variables
        string[] args = Environment.GetCommandLineArgs();
        List<Label> data = new List<Label>();
        string workingFile;
        bool isSaved, clicked, selecting, someSelection;
        int iClickX, iClickY, selx1, sely1;
        Point oldLocation   = new Point(0, 0);
        Point defaultOrigin = new Point(0, 0);

        // Settings variables
        int actualGridSize;
        float currentFontSize;
        bool selectOnimport, moveSelected, skipDoubles;

        public Form1()
        {
            // Form initialization
            InitializeComponent();
            this.Text = appName;

            // Add selection handler
            pContainer.MouseDown += pContainer_MouseDown;
            pContainer.MouseMove += pContainer_MouseMove;
            pContainer.MouseUp   += pContainer_MouseUp;
            
            // Init working vars
            workingFile = "";
            someSelection   = false;
            isSaved   = true;
            clicked   = false;
            selecting = false;
            defaultOrigin.X = globalGridSize * 3;
            defaultOrigin.Y = globalGridSize * 3;

            // Init settings according to GUI
            actualGridSize  = snapToGridToolStripMenuItem.Checked ? globalGridSize : 1;
            currentFontSize = bigFontToolStripMenuItem.Checked ? bigFontSize : smallFontSize;
            selectOnimport  = selectOnImportToolStripMenuItem.Checked;
            moveSelected    = moveSelectedToolStripMenuItem.Checked;
            skipDoubles     = skipDoublesOnImportToolStripMenuItem.Checked;
            // stripMenuItemsAvailabilityCheck(null, null);

            // Open file if necessary
            if (args.Count() > 1)
                openFile(args[1]);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = txtFilter;
            DialogResult fileOk = fd.ShowDialog();
            if (fileOk.Equals(DialogResult.OK))
                importText(fd.FileName, defaultOrigin);
        }
        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (moveSelected && (bool)clickedLabel.Tag)
            {
                if (clicked && (e.Location != oldLocation))
                {
                    DrawingControl.SuspendDrawing(pContainer);
                    dragControl(selPanel, e);
                    foreach (Label l in data)
                        if ((bool)l.Tag)
                            dragControl(l, e);
                    DrawingControl.ResumeDrawing(pContainer);
                }
                oldLocation = e.Location;
            }
            else
                if (clicked)
                    dragControl(clickedLabel, e);
        }
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
                clicked = false;
                setSavedStatus(false);
                Label l = (Label)sender;
                if (moveSelected)
                {
                    DrawingControl.SuspendDrawing(pContainer);
                    foreach (Label d in data)
                        d.Visible = true;
                    selPanel.Visible = false;
                    DrawingControl.ResumeDrawing(pContainer);
                }
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                DrawingControl.SuspendDrawing(pContainer);
                l.BringToFront();
                iClickX = e.X;
                iClickY = e.Y;
                clicked = true;
                if (moveSelected && (bool)l.Tag)
                {
                    List<Label> selected = getListOfSelected();
                    Rectangle bbox = boundingBox(selected);
                    foreach (Label d in selected)
                        d.Visible = false;
                    selPanel.Location = bbox.Location;
                    selPanel.Size = bbox.Size;
                    selPanel.SendToBack();
                    selPanel.Visible = true;
                }
                DrawingControl.ResumeDrawing(pContainer);
            }
            if (e.Button == MouseButtons.Right)
                selectLabel(l, !(bool)l.Tag);
        }
        private void pContainer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selecting = true;
                clearSelection(null, null);
                selx1 = e.X;
                sely1 = e.Y;
            }
        }
        private void pContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                selecting = false;
        }
        private void pContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (selecting)
            {
                int x1 = Math.Min(selx1, e.X);
                int x2 = Math.Max(selx1, e.X);
                int y1 = Math.Min(sely1, e.Y);
                int y2 = Math.Max(sely1, e.Y);
                Rectangle selection = new Rectangle(x1, y1, x2-x1, y2-y1);
                foreach (Label l in data)
                    if (selection.IntersectsWith(new Rectangle(l.Location, l.Size))) // Anyway ther's a select function commented below
                        selectLabel(l, true);
                    else
                        selectLabel(l, false);
            }
        }
        private void stripMenuItemsAvailabilityCheck(object sender, EventArgs e)
        {
            bool dataPresent = (data.Count > 0);
            // editToolStripMenuItem.Enabled            = dataPresent;
            // scatterToolStripMenuItem.Enabled         = dataPresent;
            // selectionToolStripMenuItem.Enabled       = dataPresent;
            deleteAllToolStripMenuItem.Enabled       = dataPresent;
            singleColumnToolStripMenuItem.Enabled    = dataPresent;
            doubleColumnToolStripMenuItem.Enabled    = dataPresent;
            gridAlignToolStripMenuItem.Enabled       = dataPresent;
            selectAllToolStripMenuItem.Enabled       = dataPresent;
            invertSelectionToolStripMenuItem.Enabled = dataPresent;

            salvaToolStripMenuItem.Enabled           = !(isSaved || workingFile.Equals(""));

            esportaToolStripMenuItem.Enabled           = someSelection;
            duplicateSelectedToolStripMenuItem.Enabled = someSelection;
            deleteToolStripMenuItem.Enabled            = someSelection;
            stackSelectedToolStripMenuItem.Enabled     = someSelection;
            pileSelectedToolStripMenuItem.Enabled      = someSelection;
            clearSelectionToolStripMenuItem.Enabled    = someSelection;
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = swdFilter;
            DialogResult fileOk = fd.ShowDialog();
            if (fileOk.Equals(DialogResult.OK))
            {
                workingFile = fd.FileName;
                saveWorkingFile(null, null);
            }
        }
        private void saveWorkingFile(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            foreach (Label l in data)
            {
                var x = l.Left.ToString();
                var y = l.Top.ToString();
                var t = l.Text;
                csv.AppendLine(string.Format("{0}{3}{1}{3}{2}", x, y, t, token));
            }
            System.IO.Stream stream = System.IO.File.Open(workingFile, System.IO.FileMode.Create);
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(stream))
            {
                writer.Write(csv.ToString());
            }
            stream.Close();
            setSavedStatus(true);
        }
        private void clearAllLabels(object sender, EventArgs e)
        {
            if (userIsSure("Do you really want to delete all items?"))
            {
                clearAll();
            }
        }
        private void clearSelectedLabels(object sender, EventArgs e)
        {
            if (userIsSure("Do you really want to delete the selected items?"))
                {
                DrawingControl.SuspendDrawing(pContainer);
                List<Label> itemsToRemove = getListOfSelected();
                foreach (Label l in itemsToRemove)
                {
                    pContainer.Controls.Remove(l);
                    data.Remove(l);
                    l.Dispose();
                }
                DrawingControl.ResumeDrawing(pContainer);
                someSelection = false;
                setSavedStatus(false);
            }
        }
        private void snapToGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snapToGridToolStripMenuItem.Checked = !snapToGridToolStripMenuItem.Checked;
            actualGridSize = snapToGridToolStripMenuItem.Checked ? globalGridSize : 1;
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Label l in data)
                selectLabel(l, true);
        }
        private void clearSelection(object sender, EventArgs e)
        {
            foreach (Label l in data)
                selectLabel(l, false);
            someSelection = false;
        }
        private void invertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            someSelection = false;
            foreach (Label l in data)
                selectLabel(l, !(bool)l.Tag);
        }
        private void esportaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = txtFilter;
            DialogResult fileOk = fd.ShowDialog();
            if (fileOk.Equals(DialogResult.OK))
            {
                System.IO.Stream stream = fd.OpenFile();
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(stream))
                {
                    foreach(Label l in getListOfSelected())
                        writer.WriteLine(l.Text);   
                }
            }
        }
        private void bigFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bigFontToolStripMenuItem.Checked = !bigFontToolStripMenuItem.Checked;
            currentFontSize = bigFontToolStripMenuItem.Checked ? bigFontSize : smallFontSize;
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in data)
                l.Font = new Font(fontName, currentFontSize);
            DrawingControl.ResumeDrawing(pContainer);
        }
        private void gridAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in data)
            {
                l.Left = (l.Left / globalGridSize) * globalGridSize;
                l.Top = (l.Top / globalGridSize) * globalGridSize;
            }
            DrawingControl.ResumeDrawing(pContainer);
            setSavedStatus(false);
        }
        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (safeDataLoss())
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = swdFilter;
                DialogResult fileOk = fd.ShowDialog();
                if (fileOk.Equals(DialogResult.OK))
                    openFile(fd.FileName);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (safeDataLoss())
            {
                workingFile = "";
                clearAll();
                someSelection = false;
                setSavedStatus(true);
            }
        }
        private void arrangeDoubleColumn(object sender, EventArgs e)
        {
            if (userIsSure("Do you really want to move all items?"))
                arrangeInColumns(data, 2, defaultOrigin);
        }
        private void arrangeSingleColumn(object sender, EventArgs e)
        {
            if (userIsSure("Do you really want to move all items?"))
                arrangeInColumns(data, 1, defaultOrigin);
        }
        private void moveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveSelectedToolStripMenuItem.Checked = !moveSelectedToolStripMenuItem.Checked;
            moveSelected = moveSelectedToolStripMenuItem.Checked;
        }
        private void duplicateSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Label> itemsToDuplicate = new List<Label>();
            foreach (Label l in data)
                if ((bool)l.Tag)
                    itemsToDuplicate.Add(l);
            clearSelection(null, null);
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in itemsToDuplicate)
            {
                Label label = newLabel(l.Text, l.Left + globalGridSize / 2, l.Top + globalGridSize / 2);
                data.Add(label);
                pContainer.Controls.Add(label);
                selectLabel(label, true);
                label.BringToFront();
                label.Visible = true;
            }
            DrawingControl.ResumeDrawing(pContainer);
            setSavedStatus(false);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutText, aboutCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void selectOnImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectOnImportToolStripMenuItem.Checked = !selectOnImportToolStripMenuItem.Checked;
            selectOnimport = selectOnImportToolStripMenuItem.Checked;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !safeDataLoss();
        }
        private void skipDoublesOnImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skipDoublesOnImportToolStripMenuItem.Checked = !skipDoublesOnImportToolStripMenuItem.Checked;
            skipDoubles = skipDoublesOnImportToolStripMenuItem.Checked;
        }
        private void stackSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Label> dataToStack = getListOfSelected();
            Point sOrigin = new Point();
            sOrigin = boundingBox(dataToStack).Location;
            arrangeInColumns(dataToStack, 2, sOrigin);
        }
        private void pileSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Label> dataToStack = getListOfSelected();
            Point sOrigin = new Point();
            sOrigin = boundingBox(dataToStack).Location;
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in dataToStack)
                l.Location = sOrigin;
            DrawingControl.ResumeDrawing(pContainer);
            setSavedStatus(false);
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                switch (Path.GetExtension(files[0]).ToLower())
                {
                    case ".txt":
                        Point p = pContainer.PointToClient(new Point(e.X, e.Y));
                        importText(files[0], p);
                        break;
                    case ".swd":
                        if ( safeDataLoss() ) openFile(files[0]);
                        break;
                    default:
                        userError("Ops!", "File type not supported!");
                        break;
                }
            }
            else userError("Ops!", "Only one file can be dropped!");
        }


        private void clearAll()
        {
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in data)
            {
                pContainer.Controls.Remove(l);
                l.Dispose();
            }
            data.Clear();
            someSelection = false;
            setSavedStatus(false);
            DrawingControl.ResumeDrawing(pContainer);
        }
        private void openFile(string filename)
        {
            clearAll();
            workingFile = filename;
            System.IO.Stream stream = File.OpenRead(filename);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                DrawingControl.SuspendDrawing(pContainer);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] d = line.Split(token);
                    string txt = String.Join(token.ToString(), d.Skip(2));
                    if (d.Length > 2)
                    {
                        Label label = newLabel(txt, Int32.Parse(d[0]), Int32.Parse(d[1]));
                        data.Add(label);
                        pContainer.Controls.Add(label);
                    }
                }
                foreach (Label l in data) l.Visible = true;
                DrawingControl.ResumeDrawing(pContainer);
            }
            setSavedStatus(true);
        }
        private void importText(string filename, Point cOrigin)
        {
            System.IO.Stream stream = File.OpenRead(filename);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                if (selectOnimport)
                    clearSelection(null, null);
                int prevDataLen = data.Count;
                DrawingControl.SuspendDrawing(pContainer);
                List<string> textData = new List<string>();
                foreach (Label l in data)
                    textData.Add(l.Text);
                while (!reader.EndOfStream)
                {
                    string txt = reader.ReadLine();
                    if (!txt.Equals("") && (!skipDoubles || !textData.Contains(txt))) // .Contains is called only if strictly required
                    {
                        Label label = newLabel(txt, 0, 0);
                        if (selectOnimport)
                            selectLabel(label, selectOnimport);
                        data.Add(label);
                        pContainer.Controls.Add(label);
                    }
                }
                arrangeInColumns(data.Skip(prevDataLen), 2, cOrigin);
                foreach (Label l in data) l.Visible = true;
                DrawingControl.ResumeDrawing(pContainer);
            }
        }
        //private Boolean selects(Rectangle rete, Label l)
        //{
        //    return rete.IntersectsWith(new Rectangle(l.Location, l.Size));
        //}
        private void setSavedStatus(bool saved)
        {
            isSaved = saved;
            string unsavedSymbol = isSaved ? "" : "*";
            string openedFile = workingFile.Equals("") ? "" : " - " + workingFile;
            this.Text = appName + openedFile + unsavedSymbol;
        }
        private void selectLabel(Label l, bool sel)
        {
            l.Tag = sel;
            if (sel)
            {
                l.ForeColor = SlabelFg;
                l.BackColor = SlabelBg;
                someSelection = true;
                // l.BringToFront();       // if active prevents paint of selected items until mouseUp
            }
            else
            {
                l.ForeColor = labelFg;
                l.BackColor = labelBg;
            }
        }
        private void arrangeInColumns(IEnumerable<Label> workingData, int nCol, Point origin)
        {
            int nx, ny;
            int count = 1;
            nx = origin.X;
            ny = origin.Y;
            DrawingControl.SuspendDrawing(pContainer);
            foreach (Label l in workingData)
            {
                l.Location = new Point(nx, ny);
                if (nCol > 1)
                {
                    nx = origin.X + columnSpacing * (count / labelPerColumn);
                    ny = origin.Y + globalGridSize * (count % labelPerColumn);
                }
                else
                {
                    nx = origin.X;
                    ny = origin.Y + globalGridSize * count;
                }
                count++;
            }
            DrawingControl.ResumeDrawing(pContainer);
            setSavedStatus(false);
        }
        private Label newLabel(string txt, Int32 x, Int32 y)
        {
            Label label = new Label();
            label.Visible = false;
            label.Text = txt;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.MouseDown += Label_MouseDown;
            label.MouseUp += Label_MouseUp;
            label.MouseMove += Label_MouseMove;
            label.Font = new Font(fontName, currentFontSize);
            label.BorderStyle = labelBorder;
            selectLabel(label, false);
            return label;
        }
        private void dragControl(Control c, MouseEventArgs o)
        {
            Point p = new Point();
            p.X = o.X + c.Left;
            p.Y = o.Y + c.Top;
            c.Left = ((p.X - iClickX) / actualGridSize) * actualGridSize;
            c.Top = ((p.Y - iClickY) / actualGridSize) * actualGridSize;
        }
        private bool safeDataLoss()
        {
            if (isSaved)
                return true;
            string message = "Do you want to save your changes?";
            string caption = "Warning: unsaved changes!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            switch (result)
            {
                case DialogResult.Yes:
                    if (workingFile != "")
                    {
                        saveWorkingFile(null, null);
                        return true;
                    } else {
                        SaveFileDialog fd = new SaveFileDialog();
                        fd.Filter = swdFilter;
                        DialogResult fileOk = fd.ShowDialog();
                        if (fileOk.Equals(DialogResult.OK))
                        {
                            workingFile = fd.FileName;
                            saveWorkingFile(null, null);
                            return true;
                        }
                        return false;
                    }
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default:
                    return false;
            }
        }
        private List<Label> getListOfSelected()
        {
            List<Label> selected = new List<Label>();
            foreach (Label l in data)
                if ((bool)l.Tag)
                    selected.Add(l);
            return selected;
        }
        private Rectangle boundingBox(List<Label> elements)
        {
            int minX = Int32.MaxValue;
            int minY = Int32.MaxValue;
            int maxX = Int32.MinValue;
            int maxY = Int32.MinValue;
            foreach (Control d in elements)
            {
                minX = Math.Min(d.Left, minX);
                minY = Math.Min(d.Top, minY);
                maxX = Math.Max(d.Left + d.Width, maxX);
                maxY = Math.Max(d.Top + d.Height, maxY);
            }
            return new Rectangle(new Point(minX, minY), new Size(maxX-minX, maxY- minY));
        }
        private bool userIsSure(string msg)
        {
            string caption = "Warning: possible data loss!";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(msg, caption, buttons, icon);
            return (result == DialogResult.OK);
        }
        private void userError(string caption, string msg)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            DialogResult result = MessageBox.Show(msg, caption, buttons, icon);
        }
    }
    class DrawingControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }
        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
}

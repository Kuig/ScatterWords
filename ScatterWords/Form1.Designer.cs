namespace ScatterWords
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaComeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scatterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pileSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.singleColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gridAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOnImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipDoublesOnImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapToGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pContainer = new System.Windows.Forms.Panel();
            this.selPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.scatterToolStripMenuItem,
            this.selectionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaComeToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.esportaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.stripMenuItemsAvailabilityCheck);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.apriToolStripMenuItem.Text = "Open...";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Enabled = false;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salvaToolStripMenuItem.Text = "Save";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.saveWorkingFile);
            // 
            // salvaComeToolStripMenuItem
            // 
            this.salvaComeToolStripMenuItem.Name = "salvaComeToolStripMenuItem";
            this.salvaComeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.salvaComeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salvaComeToolStripMenuItem.Text = "Save as...";
            this.salvaComeToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // esportaToolStripMenuItem
            // 
            this.esportaToolStripMenuItem.Enabled = false;
            this.esportaToolStripMenuItem.Name = "esportaToolStripMenuItem";
            this.esportaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.esportaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.esportaToolStripMenuItem.Text = "Export selection...";
            this.esportaToolStripMenuItem.Click += new System.EventHandler(this.esportaToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateSelectedToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.stripMenuItemsAvailabilityCheck);
            // 
            // duplicateSelectedToolStripMenuItem
            // 
            this.duplicateSelectedToolStripMenuItem.Name = "duplicateSelectedToolStripMenuItem";
            this.duplicateSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.duplicateSelectedToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.duplicateSelectedToolStripMenuItem.Text = "Duplicate selected";
            this.duplicateSelectedToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deleteToolStripMenuItem.Text = "Delete selected";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.clearSelectedLabels);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete all";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllLabels);
            // 
            // scatterToolStripMenuItem
            // 
            this.scatterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackSelectedToolStripMenuItem,
            this.pileSelectedToolStripMenuItem,
            this.toolStripSeparator4,
            this.singleColumnToolStripMenuItem,
            this.doubleColumnToolStripMenuItem,
            this.toolStripSeparator3,
            this.gridAlignToolStripMenuItem});
            this.scatterToolStripMenuItem.Name = "scatterToolStripMenuItem";
            this.scatterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.scatterToolStripMenuItem.Text = "Scatter";
            this.scatterToolStripMenuItem.DropDownOpened += new System.EventHandler(this.stripMenuItemsAvailabilityCheck);
            // 
            // stackSelectedToolStripMenuItem
            // 
            this.stackSelectedToolStripMenuItem.Name = "stackSelectedToolStripMenuItem";
            this.stackSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.stackSelectedToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.stackSelectedToolStripMenuItem.Text = "Stack selected";
            this.stackSelectedToolStripMenuItem.Click += new System.EventHandler(this.stackSelectedToolStripMenuItem_Click);
            // 
            // pileSelectedToolStripMenuItem
            // 
            this.pileSelectedToolStripMenuItem.Name = "pileSelectedToolStripMenuItem";
            this.pileSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.pileSelectedToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.pileSelectedToolStripMenuItem.Text = "Pile selected";
            this.pileSelectedToolStripMenuItem.Click += new System.EventHandler(this.pileSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(332, 6);
            // 
            // singleColumnToolStripMenuItem
            // 
            this.singleColumnToolStripMenuItem.Name = "singleColumnToolStripMenuItem";
            this.singleColumnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.singleColumnToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.singleColumnToolStripMenuItem.Text = "Arrange all as a single column";
            this.singleColumnToolStripMenuItem.Click += new System.EventHandler(this.arrangeSingleColumn);
            // 
            // doubleColumnToolStripMenuItem
            // 
            this.doubleColumnToolStripMenuItem.Name = "doubleColumnToolStripMenuItem";
            this.doubleColumnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.doubleColumnToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.doubleColumnToolStripMenuItem.Text = "Arrange all as multiple columns";
            this.doubleColumnToolStripMenuItem.Click += new System.EventHandler(this.arrangeDoubleColumn);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(332, 6);
            // 
            // gridAlignToolStripMenuItem
            // 
            this.gridAlignToolStripMenuItem.Name = "gridAlignToolStripMenuItem";
            this.gridAlignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gridAlignToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.gridAlignToolStripMenuItem.Text = "Allign to grid";
            this.gridAlignToolStripMenuItem.Click += new System.EventHandler(this.gridAlignToolStripMenuItem_Click);
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.clearSelectionToolStripMenuItem,
            this.invertSelectionToolStripMenuItem});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            this.selectionToolStripMenuItem.DropDownOpened += new System.EventHandler(this.stripMenuItemsAvailabilityCheck);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.clearSelectionToolStripMenuItem.Text = "Clear selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelection);
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.invertSelectionToolStripMenuItem.Text = "Invert selection";
            this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.invertSelectionToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectOnImportToolStripMenuItem,
            this.skipDoublesOnImportToolStripMenuItem,
            this.moveSelectedToolStripMenuItem,
            this.snapToGridToolStripMenuItem,
            this.bigFontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.viewToolStripMenuItem.Text = "Options";
            // 
            // selectOnImportToolStripMenuItem
            // 
            this.selectOnImportToolStripMenuItem.Checked = true;
            this.selectOnImportToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectOnImportToolStripMenuItem.Name = "selectOnImportToolStripMenuItem";
            this.selectOnImportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.selectOnImportToolStripMenuItem.Text = "Select on import";
            this.selectOnImportToolStripMenuItem.Click += new System.EventHandler(this.selectOnImportToolStripMenuItem_Click);
            // 
            // skipDoublesOnImportToolStripMenuItem
            // 
            this.skipDoublesOnImportToolStripMenuItem.Checked = true;
            this.skipDoublesOnImportToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skipDoublesOnImportToolStripMenuItem.Name = "skipDoublesOnImportToolStripMenuItem";
            this.skipDoublesOnImportToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.skipDoublesOnImportToolStripMenuItem.Text = "Skip duplicates on import";
            this.skipDoublesOnImportToolStripMenuItem.Click += new System.EventHandler(this.skipDoublesOnImportToolStripMenuItem_Click);
            // 
            // moveSelectedToolStripMenuItem
            // 
            this.moveSelectedToolStripMenuItem.Checked = true;
            this.moveSelectedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moveSelectedToolStripMenuItem.Name = "moveSelectedToolStripMenuItem";
            this.moveSelectedToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.moveSelectedToolStripMenuItem.Text = "Move selected together";
            this.moveSelectedToolStripMenuItem.Click += new System.EventHandler(this.moveSelectedToolStripMenuItem_Click);
            // 
            // snapToGridToolStripMenuItem
            // 
            this.snapToGridToolStripMenuItem.Checked = true;
            this.snapToGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snapToGridToolStripMenuItem.Name = "snapToGridToolStripMenuItem";
            this.snapToGridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.snapToGridToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.snapToGridToolStripMenuItem.Text = "Snap to grid";
            this.snapToGridToolStripMenuItem.Click += new System.EventHandler(this.snapToGridToolStripMenuItem_Click);
            // 
            // bigFontToolStripMenuItem
            // 
            this.bigFontToolStripMenuItem.Name = "bigFontToolStripMenuItem";
            this.bigFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bigFontToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.bigFontToolStripMenuItem.Text = "Big font";
            this.bigFontToolStripMenuItem.Click += new System.EventHandler(this.bigFontToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoScroll = true;
            this.pContainer.BackColor = System.Drawing.Color.Transparent;
            this.pContainer.BackgroundImage = global::ScatterWords.Properties.Resources.Grid16;
            this.pContainer.Controls.Add(this.selPanel);
            this.pContainer.Location = new System.Drawing.Point(0, 24);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(484, 257);
            this.pContainer.TabIndex = 2;
            // 
            // selPanel
            // 
            this.selPanel.BackColor = System.Drawing.Color.Transparent;
            this.selPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selPanel.Location = new System.Drawing.Point(211, 103);
            this.selPanel.Name = "selPanel";
            this.selPanel.Size = new System.Drawing.Size(63, 50);
            this.selPanel.TabIndex = 2;
            this.selPanel.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ScatterWords.Properties.Resources.Grid16;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ScatterWords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaComeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esportaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapToGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigFontToolStripMenuItem;
        private System.Windows.Forms.Panel selPanel;
        private System.Windows.Forms.ToolStripMenuItem scatterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem gridAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOnImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipDoublesOnImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pileSelectedToolStripMenuItem;
    }
}


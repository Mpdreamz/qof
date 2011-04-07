namespace QuickOpenFile
{
    partial class QuickOpenFileControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxOpenWithMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxStatus = new System.Windows.Forms.Label();
            this.uxOpenWith = new System.Windows.Forms.Button();
            this.uxOpenWithMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSearch
            // 
            this.uxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSearch.Location = new System.Drawing.Point(3, 19);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(611, 20);
            this.uxSearch.TabIndex = 1;
            this.uxSearch.TextChanged += new System.EventHandler(this.uxSearch_TextChanged);
            this.uxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type part of the file name here. You can use wildcards: ? = matches any character" +
                ", * = matches any string.";
            // 
            // uxOpen
            // 
            this.uxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOpen.Enabled = false;
            this.uxOpen.Location = new System.Drawing.Point(539, 196);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(75, 23);
            this.uxOpen.TabIndex = 3;
            this.uxOpen.Text = "&Open    ";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.EnabledChanged += new System.EventHandler(this.uxOpen_EnabledChanged);
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxOpenWithMenu
            // 
            this.uxOpenWithMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem});
            this.uxOpenWithMenu.Name = "contextMenuStrip1";
            this.uxOpenWithMenu.Size = new System.Drawing.Size(141, 48);
            this.uxOpenWithMenu.Opening += new System.ComponentModel.CancelEventHandler(this.uxOpenWith_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openWithToolStripMenuItem.Text = "Open With...";
            this.openWithToolStripMenuItem.Click += new System.EventHandler(this.openWithToolStripMenuItem_Click);
            // 
            // uxFiles
            // 
            this.uxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFiles.CheckBoxes = true;
            this.uxFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.uxFiles.ContextMenuStrip = this.uxOpenWithMenu;
            this.uxFiles.FullRowSelect = true;
            this.uxFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxFiles.HideSelection = false;
            this.uxFiles.Location = new System.Drawing.Point(3, 45);
            this.uxFiles.MultiSelect = false;
            this.uxFiles.Name = "uxFiles";
            this.uxFiles.Size = new System.Drawing.Size(611, 145);
            this.uxFiles.TabIndex = 2;
            this.uxFiles.UseCompatibleStateImageBehavior = false;
            this.uxFiles.View = System.Windows.Forms.View.Details;
            this.uxFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.uxFiles_ItemSelectionChanged);
            this.uxFiles.DoubleClick += new System.EventHandler(this.uxFiles_DoubleClick);
            this.uxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxFiles_KeyDown);
            this.uxFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxFiles_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 500;
            // 
            // uxStatus
            // 
            this.uxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.uxStatus.Location = new System.Drawing.Point(3, 201);
            this.uxStatus.Name = "uxStatus";
            this.uxStatus.Size = new System.Drawing.Size(530, 18);
            this.uxStatus.TabIndex = 4;
            // 
            // uxOpenWith
            // 
            this.uxOpenWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpenWith.Enabled = false;
            this.uxOpenWith.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxOpenWith.Location = new System.Drawing.Point(594, 196);
            this.uxOpenWith.Name = "uxOpenWith";
            this.uxOpenWith.Size = new System.Drawing.Size(20, 23);
            this.uxOpenWith.TabIndex = 4;
            this.uxOpenWith.Text = "▼";
            this.uxOpenWith.UseVisualStyleBackColor = true;
            this.uxOpenWith.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxOpenWith_MouseDown);
            // 
            // QuickOpenFileControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.uxOpenWith);
            this.Controls.Add(this.uxStatus);
            this.Controls.Add(this.uxFiles);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearch);
            this.Name = "QuickOpenFileControl";
            this.Size = new System.Drawing.Size(617, 222);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.uxOpenWithMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox uxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.ListView uxFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label uxStatus;
        private System.Windows.Forms.ContextMenuStrip uxOpenWithMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.Button uxOpenWith;
    }
}

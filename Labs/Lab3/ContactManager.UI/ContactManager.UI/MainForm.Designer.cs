namespace ContactManager.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._miContact = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactNew = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miContactDel = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listContacts = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miContact,
            this._miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(37, 20);
            this._miFile.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miFileExit.Size = new System.Drawing.Size(134, 22);
            this._miFileExit.Text = "&Exit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // _miContact
            // 
            this._miContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miContactNew,
            this._miContactEdit,
            this.toolStripSeparator1,
            this._miContactDel});
            this._miContact.Name = "_miContact";
            this._miContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._miContact.Size = new System.Drawing.Size(61, 20);
            this._miContact.Text = "&Contact";
            // 
            // _miContactNew
            // 
            this._miContactNew.Name = "_miContactNew";
            this._miContactNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._miContactNew.Size = new System.Drawing.Size(180, 22);
            this._miContactNew.Text = "&New";
            this._miContactNew.Click += new System.EventHandler(this.OnContactAdd);
            // 
            // _miContactEdit
            // 
            this._miContactEdit.Name = "_miContactEdit";
            this._miContactEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._miContactEdit.Size = new System.Drawing.Size(180, 22);
            this._miContactEdit.Text = "&Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // _miContactDel
            // 
            this._miContactDel.Name = "_miContactDel";
            this._miContactDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miContactDel.Size = new System.Drawing.Size(180, 22);
            this._miContactDel.Text = "&Delete";
            // 
            // _miHelp
            // 
            this._miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this._miHelp.Name = "_miHelp";
            this._miHelp.Size = new System.Drawing.Size(44, 20);
            this._miHelp.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.Size = new System.Drawing.Size(107, 22);
            this._miHelpAbout.Text = "&About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _listContacts
            // 
            this._listContacts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._listContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this._listContacts.FormattingEnabled = true;
            this._listContacts.Location = new System.Drawing.Point(0, 24);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(194, 421);
            this._listContacts.TabIndex = 1;
            this._listContacts.SelectedIndexChanged += new System.EventHandler(this.OnContactSelected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 445);
            this.Controls.Add(this._listContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem _miContact;
        private System.Windows.Forms.ToolStripMenuItem _miHelp;
        private System.Windows.Forms.ToolStripMenuItem _miContactNew;
        private System.Windows.Forms.ToolStripMenuItem _miContactEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miContactDel;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _listContacts;
    }
}


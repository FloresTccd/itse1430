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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactDel = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._listContacts = new System.Windows.Forms.ListBox();
            this._listMessages = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(92, 22);
            this._miFileExit.Text = "&Exit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miContactAdd,
            this._miContactEdit,
            this._miContactDel});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "&Contacts";
            // 
            // _miContactAdd
            // 
            this._miContactAdd.Name = "_miContactAdd";
            this._miContactAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miContactAdd.Size = new System.Drawing.Size(139, 22);
            this._miContactAdd.Text = "&Add";
            this._miContactAdd.Click += new System.EventHandler(this.OnContactAdd);
            // 
            // _miContactEdit
            // 
            this._miContactEdit.Name = "_miContactEdit";
            this._miContactEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Insert)));
            this._miContactEdit.Size = new System.Drawing.Size(139, 22);
            this._miContactEdit.Text = "&Edit";
            this._miContactEdit.Click += new System.EventHandler(this.OnContactEdit);
            // 
            // _miContactDel
            // 
            this._miContactDel.Name = "_miContactDel";
            this._miContactDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miContactDel.Size = new System.Drawing.Size(139, 22);
            this._miContactDel.Text = "&Delete";
            this._miContactDel.Click += new System.EventHandler(this.OnContactDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(126, 22);
            this._miHelpAbout.Text = "&About";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _listContacts
            // 
            this._listContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this._listContacts.FormattingEnabled = true;
            this._listContacts.Location = new System.Drawing.Point(0, 24);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(174, 426);
            this._listContacts.TabIndex = 1;
            this._listContacts.SelectedIndexChanged += new System.EventHandler(this.OnContactSelected);
            this._listContacts.DoubleClick += new System.EventHandler(this.OnContactEdit);
            // 
            // _listMessages
            // 
            this._listMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listMessages.FormattingEnabled = true;
            this._listMessages.Location = new System.Drawing.Point(174, 24);
            this._listMessages.Name = "_listMessages";
            this._listMessages.ScrollAlwaysVisible = true;
            this._listMessages.Size = new System.Drawing.Size(626, 426);
            this._listMessages.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._listMessages);
            this.Controls.Add(this._listContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miContactAdd;
        private System.Windows.Forms.ToolStripMenuItem _miContactEdit;
        private System.Windows.Forms.ToolStripMenuItem _miContactDel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ListBox _listContacts;
        private System.Windows.Forms.ListBox _listMessages;
    }
}


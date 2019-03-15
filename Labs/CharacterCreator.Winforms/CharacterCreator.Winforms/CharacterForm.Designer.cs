namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelProfession = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this._numStr = new System.Windows.Forms.NumericUpDown();
            this._numAgi = new System.Windows.Forms.NumericUpDown();
            this.groupBoxStr = new System.Windows.Forms.GroupBox();
            this.groupBoxAgi = new System.Windows.Forms.GroupBox();
            this.groupBoxInt = new System.Windows.Forms.GroupBox();
            this._numInt = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDex = new System.Windows.Forms.GroupBox();
            this._numDex = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEnd = new System.Windows.Forms.GroupBox();
            this._numEnd = new System.Windows.Forms.NumericUpDown();
            this._rbMale = new System.Windows.Forms.RadioButton();
            this._rbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numAgi)).BeginInit();
            this.groupBoxStr.SuspendLayout();
            this.groupBoxAgi.SuspendLayout();
            this.groupBoxInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numInt)).BeginInit();
            this.groupBoxDex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDex)).BeginInit();
            this.groupBoxEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(51, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 278);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(92, 7);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(196, 20);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _txtDescription
            // 
            this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDescription.Location = new System.Drawing.Point(74, 235);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(277, 84);
            this._txtDescription.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(122, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(213, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // _cbRace
            // 
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Orc",
            "Hobbit",
            "Human"});
            this._cbRace.Location = new System.Drawing.Point(92, 33);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(196, 21);
            this._cbRace.TabIndex = 1;
            this._cbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(51, 36);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 0;
            this.labelRace.Text = "Race";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(28, 63);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(56, 13);
            this.labelProfession.TabIndex = 9;
            this.labelProfession.Text = "Profession";
            // 
            // _cbProfession
            // 
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Items.AddRange(new object[] {
            "Fighter",
            "Archer",
            "Rogue",
            "Tank",
            "Wizard"});
            this._cbProfession.Location = new System.Drawing.Point(92, 60);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(196, 21);
            this._cbProfession.TabIndex = 2;
            this._cbProfession.SelectedIndexChanged += new System.EventHandler(this.OnCbProffesion);
            this._cbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProfession);
            // 
            // _numStr
            // 
            this._numStr.Location = new System.Drawing.Point(6, 38);
            this._numStr.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numStr.Name = "_numStr";
            this._numStr.Size = new System.Drawing.Size(51, 20);
            this._numStr.TabIndex = 0;
            this._numStr.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _numAgi
            // 
            this._numAgi.Location = new System.Drawing.Point(9, 38);
            this._numAgi.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numAgi.Name = "_numAgi";
            this._numAgi.Size = new System.Drawing.Size(51, 20);
            this._numAgi.TabIndex = 0;
            this._numAgi.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBoxStr
            // 
            this.groupBoxStr.Controls.Add(this._numStr);
            this.groupBoxStr.Location = new System.Drawing.Point(11, 143);
            this.groupBoxStr.Name = "groupBoxStr";
            this.groupBoxStr.Size = new System.Drawing.Size(66, 86);
            this.groupBoxStr.TabIndex = 4;
            this.groupBoxStr.TabStop = false;
            this.groupBoxStr.Text = "STR";
            // 
            // groupBoxAgi
            // 
            this.groupBoxAgi.Controls.Add(this._numAgi);
            this.groupBoxAgi.Location = new System.Drawing.Point(155, 143);
            this.groupBoxAgi.Name = "groupBoxAgi";
            this.groupBoxAgi.Size = new System.Drawing.Size(66, 86);
            this.groupBoxAgi.TabIndex = 6;
            this.groupBoxAgi.TabStop = false;
            this.groupBoxAgi.Text = "AGI";
            // 
            // groupBoxInt
            // 
            this.groupBoxInt.Controls.Add(this._numInt);
            this.groupBoxInt.Location = new System.Drawing.Point(83, 143);
            this.groupBoxInt.Name = "groupBoxInt";
            this.groupBoxInt.Size = new System.Drawing.Size(66, 86);
            this.groupBoxInt.TabIndex = 5;
            this.groupBoxInt.TabStop = false;
            this.groupBoxInt.Text = "INT";
            // 
            // _numInt
            // 
            this._numInt.Location = new System.Drawing.Point(9, 38);
            this._numInt.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numInt.Name = "_numInt";
            this._numInt.Size = new System.Drawing.Size(51, 20);
            this._numInt.TabIndex = 0;
            this._numInt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBoxDex
            // 
            this.groupBoxDex.Controls.Add(this._numDex);
            this.groupBoxDex.Location = new System.Drawing.Point(227, 143);
            this.groupBoxDex.Name = "groupBoxDex";
            this.groupBoxDex.Size = new System.Drawing.Size(66, 86);
            this.groupBoxDex.TabIndex = 7;
            this.groupBoxDex.TabStop = false;
            this.groupBoxDex.Text = "DEX";
            // 
            // _numDex
            // 
            this._numDex.Location = new System.Drawing.Point(9, 38);
            this._numDex.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numDex.Name = "_numDex";
            this._numDex.Size = new System.Drawing.Size(51, 20);
            this._numDex.TabIndex = 0;
            this._numDex.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBoxEnd
            // 
            this.groupBoxEnd.Controls.Add(this._numEnd);
            this.groupBoxEnd.Location = new System.Drawing.Point(299, 143);
            this.groupBoxEnd.Name = "groupBoxEnd";
            this.groupBoxEnd.Size = new System.Drawing.Size(66, 86);
            this.groupBoxEnd.TabIndex = 8;
            this.groupBoxEnd.TabStop = false;
            this.groupBoxEnd.Text = "END";
            // 
            // _numEnd
            // 
            this._numEnd.Location = new System.Drawing.Point(9, 38);
            this._numEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numEnd.Name = "_numEnd";
            this._numEnd.Size = new System.Drawing.Size(51, 20);
            this._numEnd.TabIndex = 0;
            this._numEnd.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _rbMale
            // 
            this._rbMale.AutoSize = true;
            this._rbMale.Location = new System.Drawing.Point(25, 19);
            this._rbMale.Name = "_rbMale";
            this._rbMale.Size = new System.Drawing.Size(48, 17);
            this._rbMale.TabIndex = 0;
            this._rbMale.TabStop = true;
            this._rbMale.Text = "Male";
            this._rbMale.UseVisualStyleBackColor = true;
            // 
            // _rbFemale
            // 
            this._rbFemale.AutoSize = true;
            this._rbFemale.Location = new System.Drawing.Point(103, 19);
            this._rbFemale.Name = "_rbFemale";
            this._rbFemale.Size = new System.Drawing.Size(59, 17);
            this._rbFemale.TabIndex = 1;
            this._rbFemale.TabStop = true;
            this._rbFemale.Text = "Female";
            this._rbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rbMale);
            this.groupBox1.Controls.Add(this._rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(91, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEnd);
            this.Controls.Add(this.groupBoxDex);
            this.Controls.Add(this.groupBoxInt);
            this.Controls.Add(this.groupBoxAgi);
            this.Controls.Add(this.groupBoxStr);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 255);
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numAgi)).EndInit();
            this.groupBoxStr.ResumeLayout(false);
            this.groupBoxAgi.ResumeLayout(false);
            this.groupBoxInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numInt)).EndInit();
            this.groupBoxDex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numDex)).EndInit();
            this.groupBoxEnd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.NumericUpDown _numStr;
        private System.Windows.Forms.NumericUpDown _numAgi;
        private System.Windows.Forms.GroupBox groupBoxStr;
        private System.Windows.Forms.GroupBox groupBoxAgi;
        private System.Windows.Forms.GroupBox groupBoxEnd;
        private System.Windows.Forms.NumericUpDown _numEnd;
        private System.Windows.Forms.GroupBox groupBoxDex;
        private System.Windows.Forms.NumericUpDown _numDex;
        private System.Windows.Forms.GroupBox groupBoxInt;
        private System.Windows.Forms.NumericUpDown _numInt;
        private System.Windows.Forms.RadioButton _rbFemale;
        private System.Windows.Forms.RadioButton _rbMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
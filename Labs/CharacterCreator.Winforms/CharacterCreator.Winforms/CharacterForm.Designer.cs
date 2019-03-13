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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._numInt = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._numDex = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._numEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numAgi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numInt)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDex)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(92, 34);
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
            this._txtDescription.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(122, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
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
            this.button2.TabIndex = 10;
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
            this._cbRace.Location = new System.Drawing.Point(92, 58);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(196, 21);
            this._cbRace.TabIndex = 1;
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(44, 61);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 0;
            this.labelRace.Text = "Race";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(29, 88);
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
            this._cbProfession.Location = new System.Drawing.Point(91, 85);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(196, 21);
            this._cbProfession.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._numStr);
            this.groupBox1.Location = new System.Drawing.Point(11, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(66, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._numAgi);
            this.groupBox2.Location = new System.Drawing.Point(155, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(66, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._numInt);
            this.groupBox3.Location = new System.Drawing.Point(83, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(66, 86);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INT";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._numDex);
            this.groupBox4.Location = new System.Drawing.Point(227, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(66, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEX";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._numEnd);
            this.groupBox5.Location = new System.Drawing.Point(299, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(66, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "END";
            // 
            // _numEnd
            // 
            this._numEnd.Location = new System.Drawing.Point(9, 38);
            this._numEnd.Minimum = new decimal(new int[] {
            50,
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
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(376, 381);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numInt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numDex)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown _numEnd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown _numDex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown _numInt;
    }
}
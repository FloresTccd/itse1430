namespace ContactManager.UI
{
    partial class SendMsgForm
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
            this._txtboxSubject = new System.Windows.Forms.TextBox();
            this._labelSubject = new System.Windows.Forms.Label();
            this._labelMessage = new System.Windows.Forms.Label();
            this._txtboxMessage = new System.Windows.Forms.TextBox();
            this._btnMsgSave = new System.Windows.Forms.Button();
            this._btnMsgCancel = new System.Windows.Forms.Button();
            this._labelEmail = new System.Windows.Forms.Label();
            this._labelTo = new System.Windows.Forms.Label();
            this._txtboxEmail = new System.Windows.Forms.TextBox();
            this._txtboxtTo = new System.Windows.Forms.TextBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtboxSubject
            // 
            this._txtboxSubject.Location = new System.Drawing.Point(73, 59);
            this._txtboxSubject.Name = "_txtboxSubject";
            this._txtboxSubject.Size = new System.Drawing.Size(434, 20);
            this._txtboxSubject.TabIndex = 0;
            this._txtboxSubject.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateSubject);
            // 
            // _labelSubject
            // 
            this._labelSubject.AutoSize = true;
            this._labelSubject.Location = new System.Drawing.Point(21, 62);
            this._labelSubject.Name = "_labelSubject";
            this._labelSubject.Size = new System.Drawing.Size(46, 13);
            this._labelSubject.TabIndex = 1;
            this._labelSubject.Text = "Subject:";
            // 
            // _labelMessage
            // 
            this._labelMessage.AutoSize = true;
            this._labelMessage.Location = new System.Drawing.Point(14, 97);
            this._labelMessage.Name = "_labelMessage";
            this._labelMessage.Size = new System.Drawing.Size(53, 13);
            this._labelMessage.TabIndex = 2;
            this._labelMessage.Text = "Message:";
            // 
            // _txtboxMessage
            // 
            this._txtboxMessage.Location = new System.Drawing.Point(73, 97);
            this._txtboxMessage.Multiline = true;
            this._txtboxMessage.Name = "_txtboxMessage";
            this._txtboxMessage.Size = new System.Drawing.Size(434, 195);
            this._txtboxMessage.TabIndex = 3;
            // 
            // _btnMsgSave
            // 
            this._btnMsgSave.Location = new System.Drawing.Point(266, 308);
            this._btnMsgSave.Name = "_btnMsgSave";
            this._btnMsgSave.Size = new System.Drawing.Size(75, 23);
            this._btnMsgSave.TabIndex = 4;
            this._btnMsgSave.Text = "&Save";
            this._btnMsgSave.UseVisualStyleBackColor = true;
            this._btnMsgSave.Click += new System.EventHandler(this.OnMsgFormSave);
            // 
            // _btnMsgCancel
            // 
            this._btnMsgCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnMsgCancel.Location = new System.Drawing.Point(386, 308);
            this._btnMsgCancel.Name = "_btnMsgCancel";
            this._btnMsgCancel.Size = new System.Drawing.Size(75, 23);
            this._btnMsgCancel.TabIndex = 5;
            this._btnMsgCancel.Text = "&Cancel";
            this._btnMsgCancel.UseVisualStyleBackColor = true;
            this._btnMsgCancel.Click += new System.EventHandler(this.OnMsgFormCancel);
            // 
            // _labelEmail
            // 
            this._labelEmail.AutoSize = true;
            this._labelEmail.Location = new System.Drawing.Point(32, 34);
            this._labelEmail.Name = "_labelEmail";
            this._labelEmail.Size = new System.Drawing.Size(35, 13);
            this._labelEmail.TabIndex = 6;
            this._labelEmail.Text = "Email:";
            // 
            // _labelTo
            // 
            this._labelTo.AutoSize = true;
            this._labelTo.Location = new System.Drawing.Point(44, 9);
            this._labelTo.Name = "_labelTo";
            this._labelTo.Size = new System.Drawing.Size(23, 13);
            this._labelTo.TabIndex = 7;
            this._labelTo.Text = "To:";
            // 
            // _txtboxEmail
            // 
            this._txtboxEmail.BackColor = System.Drawing.SystemColors.Control;
            this._txtboxEmail.Location = new System.Drawing.Point(73, 31);
            this._txtboxEmail.Name = "_txtboxEmail";
            this._txtboxEmail.ReadOnly = true;
            this._txtboxEmail.Size = new System.Drawing.Size(434, 20);
            this._txtboxEmail.TabIndex = 8;
            // 
            // _txtboxtTo
            // 
            this._txtboxtTo.BackColor = System.Drawing.SystemColors.Control;
            this._txtboxtTo.Location = new System.Drawing.Point(73, 6);
            this._txtboxtTo.Name = "_txtboxtTo";
            this._txtboxtTo.ReadOnly = true;
            this._txtboxtTo.Size = new System.Drawing.Size(434, 20);
            this._txtboxtTo.TabIndex = 9;
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // SendMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnMsgCancel;
            this.ClientSize = new System.Drawing.Size(524, 355);
            this.Controls.Add(this._txtboxtTo);
            this.Controls.Add(this._txtboxEmail);
            this.Controls.Add(this._labelTo);
            this.Controls.Add(this._labelEmail);
            this.Controls.Add(this._btnMsgCancel);
            this.Controls.Add(this._btnMsgSave);
            this.Controls.Add(this._txtboxMessage);
            this.Controls.Add(this._labelMessage);
            this.Controls.Add(this._labelSubject);
            this.Controls.Add(this._txtboxSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Message";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _labelSubject;
        private System.Windows.Forms.Label _labelMessage;
        private System.Windows.Forms.Button _btnMsgSave;
        private System.Windows.Forms.Button _btnMsgCancel;
        private System.Windows.Forms.Label _labelEmail;
        private System.Windows.Forms.Label _labelTo;
        public System.Windows.Forms.TextBox _txtboxSubject;
        public System.Windows.Forms.TextBox _txtboxMessage;
        public System.Windows.Forms.TextBox _txtboxEmail;
        public System.Windows.Forms.TextBox _txtboxtTo;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}
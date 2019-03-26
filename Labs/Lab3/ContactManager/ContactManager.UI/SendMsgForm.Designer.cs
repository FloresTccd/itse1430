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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._labelSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._btnMsgSave = new System.Windows.Forms.Button();
            this._btnMsgCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(434, 195);
            this.textBox2.TabIndex = 3;
            // 
            // _btnMsgSave
            // 
            this._btnMsgSave.Location = new System.Drawing.Point(266, 308);
            this._btnMsgSave.Name = "_btnMsgSave";
            this._btnMsgSave.Size = new System.Drawing.Size(75, 23);
            this._btnMsgSave.TabIndex = 4;
            this._btnMsgSave.Text = "&Save";
            this._btnMsgSave.UseVisualStyleBackColor = true;
            // 
            // _btnMsgCancel
            // 
            this._btnMsgCancel.Location = new System.Drawing.Point(386, 308);
            this._btnMsgCancel.Name = "_btnMsgCancel";
            this._btnMsgCancel.Size = new System.Drawing.Size(75, 23);
            this._btnMsgCancel.TabIndex = 5;
            this._btnMsgCancel.Text = "&Cancel";
            this._btnMsgCancel.UseVisualStyleBackColor = true;
            this._btnMsgCancel.Click += new System.EventHandler(this.OnMsgFormCancel);
            // 
            // SendMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 353);
            this.Controls.Add(this._btnMsgCancel);
            this.Controls.Add(this._btnMsgSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._labelSubject);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "SendMsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _labelSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button _btnMsgSave;
        private System.Windows.Forms.Button _btnMsgCancel;
    }
}
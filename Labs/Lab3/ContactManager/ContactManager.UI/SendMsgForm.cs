/*
    Lab 3 ITSE1430
    Raul Flores
    April 1, 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
   

    public partial class SendMsgForm : Form
    {
        
        public SendMsgForm()
        {
            InitializeComponent();
            
        }
        
        public MyMessage Message { get; set; }

        private void OnMsgFormCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            
           

            ValidateChildren();
        }

        private void OnMsgFormSave( object sender, EventArgs e )
        {
            if(!ValidateChildren())
                return;

            if (String.IsNullOrEmpty(_txtboxSubject.Text))
            {
                MessageBox.Show(this, "Subject is Required.", "Error", MessageBoxButtons.OK);
                return;
            };

            Message = SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnValidateSubject( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Subject is required.");
                e.Cancel = false;
            } else
                _errors.SetError(tb, "");
        }

        private MyMessage SaveData()
        {
            var message = new MyMessage();
            message.Contact = _txtboxtTo.Text;
            message.Email = _txtboxEmail.Text;
            message.Subject = _txtboxSubject.Text;
            message.Body = _txtboxMessage.Text;
            return message;
        }
    }
}

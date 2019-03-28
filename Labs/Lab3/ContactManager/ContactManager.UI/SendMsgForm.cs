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
    }
}

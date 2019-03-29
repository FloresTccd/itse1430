/*
    Lab 3 ITSE1430
    Raul Flores
    April 1, 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        //Called when the user saves
        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            
            if (!contact.Validate())
            {
                MessageBox.Show(this, "Name and Valid Email Required.", "Error", MessageBoxButtons.OK);
                return;
            };

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData(Contact contact)
        {
            _txtName.Text = contact.Name;
            _txtEmail.Text = contact.Email;

        }

        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = _txtName.Text;
            contact.Email = _txtEmail.Text;

            return contact;
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Contact != null)
                LoadData(Contact);

            ValidateChildren();
        }

        private void OnValidateName( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = false;
            } else
                _errors.SetError(tb, "");
        }

        private void OnValidateEmail( object sender, System.ComponentModel.CancelEventArgs e )
        {
            
            var tb = sender as TextBox;

            if (!IsValidEmail(_txtEmail.Text))
            {
                _errors.SetError(tb, "Please provide valid Email Address");
                e.Cancel = false;
                

            } else
                _errors.SetError(tb, "");



        }

        public bool IsValidEmail (string source)
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;

        }

       
    }
}

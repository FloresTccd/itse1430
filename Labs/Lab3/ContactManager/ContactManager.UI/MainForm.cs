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
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }
       

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnContactAdd( object sender, EventArgs e )
        {
            var form = new ContactForm();

            while (true)
            {
                //Modal
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //Add
                try
                {
                    //Anything in here that raises an exception will
                    //be sent to the catch block

                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            };

            BindList();

        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            BindList();

        }

        private void BindList()
        {
            //Bind contacts to listbox
            
            _listContacts.Items.Clear();
            _listContacts.DisplayMember = nameof(Contact.Name);
            _listContacts.Items.AddRange(_contacts.GetAll().ToArray());


            //msg display
            _listMessages.Items.Clear();
            _listMessages.DisplayMember = nameof(FakeMessage);
            
           

            foreach (var message in _emailMessages)
            {
                if (message != null)
                    _listMessages.Items.Add(message);
            };
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( ContactForm form )
        {
            try
            {
                
                _contacts.Add(form.Contact);
            } catch (NotImplementedException e)
            {
                //Rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                
                throw;
            };
        }

        private IContactDatabase _contacts = new ContactDatabase();

        private void OnContactEdit( object sender, EventArgs e )
        {
            var form = new ContactForm();

            var contact = GetSelectedContact();
            if (contact == null)
                return;

            //contact to edit

            form.Contact = contact;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                              
                    _contacts.Update(contact.Id, form.Contact);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnContactDelete( object sender, EventArgs e )
        {

            var selected = GetSelectedContact();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                
                _contacts.Delete(selected.Id);
            } catch (Exception ex)
            {
                DisplayError(ex);
            };
            BindList();
        }

        public Contact GetSelectedContact()
        {
            var value = _listContacts.SelectedItem;

            

            //Preferred - null if not valid
            var contact = value as Contact;

            //Type check
            var contact2 = (value is Contact) ? (Contact)value : null;

            return _listContacts.SelectedItem as Contact;
        }

        private void OnContactSelected( object sender, EventArgs e )
        {
            

           


        }

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            if (MessageBox.Show(this, "Are you sure?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            };
            base.OnFormClosing(e);
        }

        private void OnSendMsg( object sender, EventArgs e )
        {

            SendMsgForm _form = new SendMsgForm();
            var contact = GetSelectedContact();

          

            if (contact == null)
            {
                MessageBox.Show(this, "Please choose Contact to send message.", "Error", MessageBoxButtons.OK);
                return;
            }
            
            _form._txtboxtTo.Text = contact.Name;
            _form._txtboxEmail.Text = contact.Email;
                               

            //Modal
            if (_form.ShowDialog(this) != DialogResult.OK)
                return;

            _emailMessages[GetNextEmptyMessage()] = _form.Message;
            BindList();

        }

        private FakeMessage[] _emailMessages = new FakeMessage[100];

        private int GetNextEmptyMessage()
        {
            for (var index = 0; index < _emailMessages.Length; ++index)
                if (_emailMessages[index] == null)
                    return index;

            return -1;
        }


    }
    public class Send : IMessageService
    {
        FakeMessage IMessageService.Send( FakeMessage message )
        {
            throw new NotImplementedException();
        }
    }
}

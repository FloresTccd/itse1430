using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactCreator;

namespace ContactManager.UI
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the property being edited.</summary>
        public Contact Contact { get; set; }
        private void OnSave( object sender, EventArgs e )//Called when the user saves the game
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();


            //validate - at business level
            try
            {
                //new ObjectValidator().Validate();
            } catch (ValidationException)
            {
                MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
                return;
            };
            


            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();

        }
        private void OnCancel( object sender, EventArgs e )//Called when the user cancels the add/edit
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        


        private void LoadData( Contact contact )  //loads UI with game
        {
            _txtName.Text = contact.Name;
            _txtEmail.Text = contact.Email;
            
        }
        private Contact SaveData() //Saves UI into new game
        {
            var contact = new Contact() {
                Name = _txtName.Text,
                Email = _txtEmail.Text
            };




            return contact;
        }

       


        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);



            //init UI if editing a game
            if (Contact != null)
                LoadData(Contact);


            ValidateChildren(); // to display icon on required items
        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox; // casting as txbox

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
            {
                _errors.SetError(tb, "");
            }
        }

        
    }
}

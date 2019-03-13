using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
           _cbRace.DataSource = Enum.GetValues(typeof(CharacterRace)); 
        }

        public Character Character { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadData( Character character )
        {
            _txtName.Text = character.Name;
            _txtDescription.Text = character.Description;
           
            

        }

        private Character SaveData()
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Description = _txtDescription.Text;
            
            



            return character;
        }

        protected virtual void CanBeChanged() { }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
           


            if (Character != null)
                LoadData(Character);
      

            ValidateChildren();
        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
            {
                _errors.SetError(tb, "");
            }
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var character = SaveData();


            //validate - at business level
            if (!character.Validate())
            {
                MessageBox.Show("Character not valid.", "Error", MessageBoxButtons.OK);
                return;

            }


            Character = character;
            DialogResult = DialogResult.OK;
            Close();

        }

       
    }
}

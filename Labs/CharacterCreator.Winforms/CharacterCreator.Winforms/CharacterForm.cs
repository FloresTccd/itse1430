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
            _cbProfession.DataSource = Enum.GetValues(typeof(CharacterProfession));
            
           
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
            _cbRace.SelectedItem = character.Race;
            _cbProfession.SelectedItem = character.Profession;
            _numStr.Value= character.Strength;
            _numInt.Value = character.Intelligence;
            _numAgi.Value = character.Agility;
            _numDex.Value = character.Dexterity;
            _numEnd.Value = character.Endurance;
            

        }

        private Character SaveData()
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Description = _txtDescription.Text;
            CharacterRace characterRace = (CharacterRace)_cbRace.SelectedItem;
            character.Race = characterRace;
            CharacterProfession characterProfession = (CharacterProfession)_cbProfession.SelectedItem;
            character.Profession = characterProfession;
            character.Strength = _numStr.Value;
            character.Intelligence = _numInt.Value;
            character.Agility = _numAgi.Value;
            character.Dexterity = _numDex.Value;
            character.Endurance = _numEnd.Value;


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

        private void OnValidateRace( object sender, CancelEventArgs e )
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex == 0)
            {
                _errors.SetError(cb, "Race is required.");
                e.Cancel = true;
            } else
            {
                _errors.SetError(cb, "");
            }

        }

        private void OnValidateProfession( object sender, CancelEventArgs e )
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex == 0)
            {
                _errors.SetError(cb, "Profession is required.");
                e.Cancel = true;
            } else
            {
                _errors.SetError(cb, "");
            }

        }

        
    }
}

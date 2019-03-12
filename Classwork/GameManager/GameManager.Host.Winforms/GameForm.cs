using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    /// <summary>Allows adding or editing a game.</summary>
    public partial class GameForm : Form
    {
        public GameForm() //: base()  <--Implicit  called but no need to show it
        {
            InitializeComponent();
        }


        /// <summary>Gets or sets the property being edited.</summary>
        public Game Game { get; set; }
        private void OnSave( object sender, EventArgs e )//Called when the user saves the game
        {
            if (!ValidateChildren())
                return;

           var game = SaveData();

        
            //validate - at business level
            if (!game.Validate())
            {
                MessageBox.Show("Game not valid.", "Error", MessageBoxButtons.OK);
                return;

            }


            Game = game;
            DialogResult = DialogResult.OK;
            Close();

        }
        private void OnCancel( object sender, EventArgs e )//Called when the user cancels the add/edit
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private decimal ReadDecimal( TextBox control )
        {
            if (control.Text.Length == 0)
                return 0;

            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }


        private void LoadData( Game game )  //loads UI with game
        {
            _txtName.Text = game.Name;
            _txtDescription.Text = game.Description;
            _txtPrice.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }
        private Game SaveData() //Saves UI into new game
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Description = _txtDescription.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked;
            game.Completed = _cbCompleted.Checked;

            //Demoing ctor
            var game2 = new Game(_txtName.Text, ReadDecimal(_txtPrice));

            return game;
        }

        //Define in type
        //derived type may override and change it
        protected virtual void CanBeChanged() { }

       
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
            
          

            //init UI if editing a game
            if (Game != null)
                LoadData(Game);
           

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

        private void OnValidatePrice( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            var price = ReadDecimal(tb);
            if (price < 0)
            {
                _errors.SetError(tb, "Price > = 0");
                e.Cancel = true;
            } else
            {
                _errors.SetError(tb, "");
            }
        }

       
    }
}

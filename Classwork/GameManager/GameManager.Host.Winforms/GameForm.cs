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
        public GameForm()
        {
            InitializeComponent();
        }
        /// <summary>Gets or sets the property being edited.</summary>
        public Game Game { get; set; }
        private void OnSave( object sender, EventArgs e )//Called when the user saves the game
        {
            Game = SaveData();
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
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }


        private void LoadData( Game game )  //loads UI with game
        {
            _txtName.Text = game.Name;
            _txtPublisher.Text = game.Publisher;
            _txtPrice.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }
        private Game SaveData() //Saves UI into new game
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Publisher = _txtPublisher.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked;
            game.Completed = _cbCompleted.Checked;

            return game;
        }

        private void GameForm_Load( object sender, EventArgs e )
        {
            //init UI if editing a game
            if (Game != null)
                LoadData(Game);
        }
    }
}

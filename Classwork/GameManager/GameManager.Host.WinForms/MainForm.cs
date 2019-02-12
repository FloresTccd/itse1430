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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUI();
        }

        void LoadUI ()
        {
            Game game = new Game();

            game.Name = "DOOM";
            game.Price = 59.99M;

            var name = game.Name;
            if (name.Length == 0)
                /* is empty*/;
            if (game.Name.Length == 0)
                /* is empty */
                ;

            var isCool = game.IsCoolGame;
            //game.IsCoolGame = false;

            //Validate(game)
            game.Validate();

            //var x = 10;
            //x.ToString();

            //var str = game.Publisher;            
            //Decimal.TryParse("45.99", out game.Price);
            
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            //Local variable
            var x = 10;

            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            MessageBox.Show("Help");
        }

        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI

            //If OK then "add" to system
        }
    }
}

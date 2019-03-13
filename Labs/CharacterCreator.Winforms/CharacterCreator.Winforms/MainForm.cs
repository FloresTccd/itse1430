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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //LoadUI();
        }

        private void OnFileExit( object sender, EventArgs e )
        {

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            BindList();
        }

        private void BindList()
        {
            //Bind games to listbox
            _listCharacters.Items.Clear();
            _listCharacters.DisplayMember = nameof(Character.Name);

            //Can use AddRange now that we don't care about null items
            _listCharacters.Items.AddRange(_characters.GetAll());

        }

        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI
            var form = new CharacterForm();

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

                    //_games[GetNextEmptyGame()] = form.Game;
                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Choose a better game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };

            };

            BindList();
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( CharacterForm form )
        {
            try
            {
                //_games[GetNextEmptyGame()] = form.Game;
                _characters.Add(form.Character);
            } catch (NotImplementedException e)
            {
                //Rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                //Log a message 

                //Rethrow exception - wrong way
                //throw e;
                throw;
            };
        }

        private CharacterDB _characters = new CharacterDB();

        private void OnGameEdit( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            var game = GetSelectedCharacter();
            if (game == null)
                return;

            //Game to edit
            form.Character = game;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    //UpdateGame(game, form.Game);            
                    _characters.Update(game.Id, form.Character);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            //Get selected game, if any
            var selected = GetSelectedCharacter();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                //DeleteGame(selected);
                _characters.Delete(selected.Id);
            } catch (Exception ex)
            {
                DisplayError(ex);
            };
            BindList();
        }

        private Character GetSelectedCharacter()
        {
            var value = _listCharacters.SelectedItem;


            //Preferred - null if not valid
            var game = value as Character;

            //Type check
            var game2 = (value is Character) ? (Character)value : null;

            return _listCharacters.SelectedItem as Character;
        }

        private void OnGameSelected( object sender, EventArgs e )
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





    }
}

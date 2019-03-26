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

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        //protected override void OnLoad( EventArgs e )
        //{
        //    base.OnLoad(e);

        //    BindList();
        //}

        //private void BindList()
        //{
        //    //Bind characters to listbox
        //    _listContacts.Items.Clear();
        //    _listContacts.DisplayMember = nameof(Character.Name);

        //    //AddRange
        //    _listContacts.Items.AddRange(_characters.GetAll());

        //}

        //private void OnCharacterAdd( object sender, EventArgs e )
        //{
        //    //Display UI
        //    var form = new CharacterForm();

        //    while (true)
        //    {
        //        //Modal
        //        if (form.ShowDialog(this) != DialogResult.OK)
        //            return;

        //        //Add
        //        try
        //        {
        //            OnSafeAdd(form);
        //            break;
        //        } catch (InvalidOperationException)
        //        {
        //            MessageBox.Show(this, "Pick Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        } catch (Exception ex)
        //        {
        //            //Recover from errors
        //            DisplayError(ex);
        //        };

        //    };

        //    BindList();
        //}

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //private void OnSafeAdd( CharacterForm form )
        //{
        //    try
        //    {
        //        _characters.Add(form.Character);
        //    } catch (NotImplementedException e)
        //    {
        //        //Rewriting an exception
        //        throw new Exception("Not implemented yet", e);
        //    } catch (Exception e)
        //    {
        //        throw;
        //    };
        //}

        //private void OnCharacter( object sender, EventArgs e )
        //{
        //    var form = new CharacterForm();
        //    form.Text = "Edit Character";

        //    var character = GetSelectedCharacter();
        //    if (character == null)
        //        return;

        //    //Character edit
        //    form.Character = character;

        //    while (true)
        //    {
        //        if (form.ShowDialog(this) != DialogResult.OK)
        //            return;

        //        try
        //        {
        //            _characters.Update(character.Id, form.Character);
        //            break;
        //        } catch (Exception ex)
        //        {
        //            DisplayError(ex);
        //        };
        //    };

        //    BindList();
        //}

        //private void OnGameDelete( object sender, EventArgs e )
        //{

        //    var selected = GetSelectedCharacter();
        //    if (selected == null)
        //        return;

        //    //Display confirmation
        //    if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
        //                       "Confirm Delete", MessageBoxButtons.YesNo,
        //                       MessageBoxIcon.Question) != DialogResult.Yes)
        //        return;

        //    try
        //    {
        //        _characters.Delete(selected.Id);
        //    } catch (Exception ex)
        //    {
        //        DisplayError(ex);
        //    };
        //    BindList();
        //}

        //private Character GetSelectedCharacter()
        //{
        //    var value = _listContacts.SelectedItem;


        //    //Preferred - null if not valid
        //    var character = value as Character;

        //    //Type check
        //    var character2 = (value is Character) ? (Character)value : null;

        //    return _listContacts.SelectedItem as Character;
        //}

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

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if (keyData == (Keys.F1))
            {
                var form = new AboutBox();
                form.ShowDialog();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //private CharacterDB _characters = new CharacterDB();

      
    }
}


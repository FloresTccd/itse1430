/*
    Lab 2 ITSE1430
    Raul Flores
    March 15, 2019
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public enum CharacterRace { Unknown,Dwarf, Elf,Orc,Hobbit,Human}
    public enum CharacterProfession {Unknown,Fighter,Archer,Rogue,Tank,Wizard}
 
    public class Character
    {
        public int Id { get; set; }

        #region Property
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        public CharacterRace Race
        {
            get { return _race; }
            set { _race = value; }
        }
        public CharacterProfession Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }
        public decimal Strength { get => _strength; set => _strength = value; }
        public decimal Intelligence { get => _intelligence; set => _intelligence = value; }
        public decimal Agility { get => _agility; set => _agility = value; }
        public decimal Dexterity { get => _dexterity; set => _dexterity = value; }
        public decimal Endurance { get => _endurance; set => _endurance = value; }
        public bool Male { get => _male; set => _male = value; }
        public bool Female { get => _female; set => _female = value; }

        #endregion

        #region Constructor
        public Character()
        {
            Name = "";
            Race = CharacterRace.Unknown;
            Profession = CharacterProfession.Unknown;
            Strength =50;
            Intelligence = 50;
            Agility = 50;
            Dexterity = 50;
            Endurance = 50;
            Male = false;
            Female = false;

        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession )
        {
            Name = name;
            Race = characterRace;
            Profession = characterProfession;
        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession, decimal strength, decimal intelligence,
            decimal agility, decimal dexterity, decimal endurance )
        {
            Name = name;
            Race = characterRace;
            Profession = characterProfession;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
            Dexterity = dexterity;
            Endurance = endurance;

        }
        #endregion

        #region Private Members
        private string _name = "";
        private string _description = "";
        private bool _male = false;
        private bool _female = false;
        private CharacterRace _race;
        private CharacterProfession _profession;
        private decimal _strength;
        private decimal _intelligence;
        private decimal _agility;
        private decimal _dexterity;
        private decimal _endurance;
        
        #endregion

        public override string ToString()
        {
            return Name;
        }

        public bool Validate()
        {

            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            return true;
        }
    }
}

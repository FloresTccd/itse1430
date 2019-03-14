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
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Endurance { get => _endurance; set => _endurance = value; }


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
        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession )
        {
            Name = name;
            Race = characterRace;
            Profession = characterProfession;
        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession, int strength, int intelligence,
            int agility, int dexterity, int endurance )
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



        #region Private Members
        private string _name = "";
        private string _description = "";
        private CharacterRace _race;
        private CharacterProfession _profession;
        private decimal _strength;
        private int _intelligence;
        private int _agility;
        private int _dexterity;
        private int _endurance;
        #endregion


    }
}

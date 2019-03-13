using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public enum CharacterRace {Dwarf,Elf,Orc,Hobbit,Human,Unknown}
    public enum CharacterProfession {Fighter,Archer,Rogue,Tank,Wizard,Unknown}

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
        public int Strength { get => _strength; set => _strength = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }


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
            Strength = 50;
            Intelligence = 50;
            Agility = 50;
            Constitution = 50;
            Charisma = 50;
        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession )
        {
            Name = name;
            Race = characterRace;
            Profession = characterProfession;
        }

        public Character( string name, CharacterRace characterRace, CharacterProfession characterProfession, int strength, int intelligence,
            int agility, int constitution, int charisma )
        {
            Name = name;
            Race = characterRace;
            Profession = characterProfession;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
            Constitution = constitution;
            Charisma = charisma;

        }



        #region Private Members
        private string _name = "";
        private string _description = "";
        private CharacterRace _race;
        private CharacterProfession _profession;
        private int _strength;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase : IContactDatabase
    {
        public Contact Add(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

                     
            
            if (!contact.Validate())
              throw new Exception("Contact is invalid.");

            //Game names must be unique
            var existing = GetIndex(contact.Name);
            if (existing >= 0)
                throw new Exception("Contact must be unique.");


            contact.Id = ++_nextId;
            _items.Add(Clone(contact));

            return contact;


        }

        public void Delete( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
            
        }

        public Contact Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public IEnumerable<Contact> GetAll()
        {

            var temp = new List<Contact>();
            foreach (var item in _items)
                temp.Add(Clone(item));

            return temp.ToArray();
        }

        public Contact Update( int id, Contact contact )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            
            if (!contact.Validate())
                throw new Exception("Contact is invalid");
           

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Game does not exist.");

            //contact names must be unique            
            var existingIndex = GetIndex(contact.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("contact must be unique.");

            contact.Id = id;
            var existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        private Contact Clone( Contact contact )
        {
            var newGame = new Contact();
            Clone(newGame, contact);

            return newGame;
        }

        private void Clone( Contact target, Contact source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
            
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Count; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }




        private readonly List<Contact> _items = new List<Contact>();
        private int _nextId = 0;
    }
}

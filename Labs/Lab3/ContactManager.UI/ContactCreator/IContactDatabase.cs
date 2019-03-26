using System.Collections.Generic;
using ContactCreator;

namespace ContactCreator
{
    public interface IContactDatabase
    {
        Contact Add( Contact contact );
        void Delete( int id );
        Contact Get( int id );
        IEnumerable<Contact> GetAll();
        Contact Update( int id, Contact contact );
    }
}
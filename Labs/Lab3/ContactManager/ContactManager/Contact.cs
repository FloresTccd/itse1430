using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact
    {
        #region Property
        public int Id { get; set; }
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }
        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value; }
        }
        #endregion

        #region Private Members
        private string _name = "";
        private string _email = "";
        #endregion


        public Contact()
        {
            Name = "";


        }

        public override string ToString()
        {
            return Name;
        }

        
        public bool Validate( )
        {
           
            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;
            if (!IsValidEmail(Email))
                return false;
            
            return true;
        }

        public bool IsValidEmail( string source )
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;

        }

    }
}

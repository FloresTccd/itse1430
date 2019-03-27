using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Message
    {

        #region Private Members
        private string _contact = "";
        private string _subject = "";
        private string _body = "";
        #endregion

        #region Property
        public string Contact { get => _contact; set => _contact = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Body { get => _body; set => _body = value; }
        #endregion

        public bool Validate()
        {

            //Name is required
            if (String.IsNullOrEmpty(Contact))
                return false;
            if (String.IsNullOrEmpty(Subject))
                return false;
            if (String.IsNullOrEmpty(Body))
                return false;


            return true;
        }



    }
}

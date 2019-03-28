using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public static class ObjectValidator
    {
       // private ObjectValidator()
        //{ }
        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));
            //No access to instance members
            //_duh = 10;
        }
        //private int _duh;
    }
}

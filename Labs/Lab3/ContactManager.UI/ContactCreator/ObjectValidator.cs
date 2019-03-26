using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCreator;

namespace ContactCreator

{
    public class ObjectValidator
    {
        public void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));

        }

        internal void Validate( Contact contact )
        {
            throw new NotImplementedException();
        }
    }
}

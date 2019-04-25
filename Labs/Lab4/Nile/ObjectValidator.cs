/*
    Lab 4 ITSE1430
    Raul Flores
    April 29, 2019
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class ObjectValidator
    {
        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));

    
        }
    }
}

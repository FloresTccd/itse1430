/*
    Lab 4 ITSE1430
    Raul Flores
    April 29, 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nile
{
    /// <summary>Represents a product.</summary>
    public class Product
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }
        
        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the price.</summary>
        [Range(0, Double.MaxValue, ErrorMessage = "Price must be >= 0.")]
        public decimal Price { get; set; } = 0;      

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public bool Validate()
        {
            if (String.IsNullOrEmpty(Name))
                return false;
            if (Price < 0)
                return false;
            if (Id < 0)
                return false;

            return true;

        }

        public override string ToString()
        {
            return Name;
        }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

           

            return items;
        }


        #region Private Members

        private string _name;
        private string _description;
        #endregion
    }
}

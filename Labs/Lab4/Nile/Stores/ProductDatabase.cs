/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var sameName = FindByName(product.Name);
            if (sameName != null)
                throw new Exception("Product must be unique.");

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be >0.");

            return GetCore(id);
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be >0.");

            RemoveCore(id);
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( int id,Product product )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            if (product == null)
                throw new ArgumentNullException(nameof(product));

            

            //Get existing product
            var existing = GetCore(product.Id);
            if (existing == null)
                throw new Exception("Game does not exist.");

            var sameName = FindByName(product.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Game must be unique.");


            return UpdateCore(id, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( int id, Product newProduct );

        protected abstract Product AddCore( Product product );

        protected virtual Product FindByName(string name)
        {
            return (from product in GetAllCore()
                    where String.Compare(product.Name, name, true) == 0
                    select product).FirstOrDefault();

        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary>Represents a game.</summary>
    public class Game
    {
        /// <summary>Name of the Game.</summary>
        public string Name = "";

        /// <summary>Publisher of the Game. </summary>
        public string Publisher = "";
        public decimal Price;
        public bool Owned;
        public bool Completed;

        /// <summary>Validates the object.</summary>
        /// <returns></returns>
        public bool Validate( /* Game this */ )
        {
            //Redundant dude
            //var str = this.Name;

            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            //Price >= 0
            if (Price < 0)
                return false;

            //Only if you need to pass the instance to somebody else
            //MyType.Foo(this);

            return true;
        }


    }
}

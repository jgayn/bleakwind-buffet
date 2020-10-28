using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Abstract class to describe entrees
    /// </summary>
    public abstract class Entree
    {
        /// <value>
        /// Public property to access/set price of the entree
        /// </value>
        public abstract double Price
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set calories of the entree
        /// </value>
        public abstract uint Calories
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set special instructions of the entree
        /// </value>
        public abstract List<string> SpecialInstructions
        {
            get;
            set;
        }
    }
}

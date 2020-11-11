using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data
{
    /// <summary>
    /// Abstract class to describe drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Public property to get/set size of the drink
        /// </summary>
        public abstract Size Size
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set price of the drink
        /// </value>
        public abstract double Price
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set calories of the drink
        /// </value>
        public abstract uint Calories
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set special instructions of the drink
        /// </value>
        public abstract List<string> SpecialInstructions
        {
            get;
            set;
        }

        /// <summary>
        /// Public property to access description of item
        /// </summary>
        public abstract string Description
        {
            get;
        }
    }
}

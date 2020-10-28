using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Abstract class to describe sides
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Public property to get/set size of the side
        /// </summary>
        public abstract Size Size
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set price of the side
        /// </value>
        public abstract double Price
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set calories of the side
        /// </value>
        public abstract uint Calories
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set special instructions of the side
        /// </value>
        public abstract List<string> SpecialInstructions
        {
            get;
            set;
        }
    }
}

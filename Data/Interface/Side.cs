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
        public Size Size
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set price of the side
        /// </value>
        public double Price
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set calories of the side
        /// </value>
        public uint Calories
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set special instructions of the side
        /// </value>
        public List<string> SpecialInstructions
        {
            get;
            set;
        }
    }
}

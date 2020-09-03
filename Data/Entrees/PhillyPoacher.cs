/* Author: Jared Gaynor
 * Class: PhillyPoacher.cs
 * Purpose: Is a model for information about the entree "Philly Poacher"
 * 
 * 
 * I am from philly, this item better be the best on the menu. (also ribeye > sirloin)
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Philly Poacher.
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private double price = 7.23;
        private uint calories = 784;
        private List<string> specialinstructions = new List<string>();
        private bool sirloin = true;
        private bool onions = true;
        private bool roll = true;

        /// <summary>
        /// Public property for whether or not customer wants sirloin steak.
        /// Can get value or set a new value.
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold sirloin");
                sirloin = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants onions.
        /// Can get value or set a new value.
        /// </summary>
        public bool Onions
        {
            get { return onions; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold onions");
                onions = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants a roll.
        /// Can get value or set a new value.
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold roll");
                roll = value;
            }
        }

        /// <summary>
        /// Public property to return the price of this entree.
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Public property to return the amount of calories in this entree.
        /// </summary>
        public uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Returns a list of special instructions the customer can give.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get { return specialinstructions; }
        }

        /// <summary>
        /// Overrides the ToString() to return the name of the entree and not a garbage value.
        /// </summary>
        /// <returns>The name of this entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

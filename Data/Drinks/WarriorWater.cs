/* Author: Jared Gaynor
 * Class: WarriorWater.cs
 * Purpose: Is a model for information about an order of Warrior Water.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Warrior Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value>Stores whether ice is in the drink</value>
        private bool ice = true;

        /// <value>Stores whether lemon is in the drink</value>
        private bool lemon = false;

        /// <value> Stores and initializes the size of the drink to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value> Stores and initializes the price of the drink to that of a small </value>
        private double price = 0;

        /// <value> Stores and initializes the calories of the drink ot that of a small </value>
        private uint calories = 0;

        /// <value>
        /// Gets/sets whether the customer wants ice in their water.
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold ice");
                ice = value;
            }
        }

        /// <value>
        /// Gets/sets whether the customer wants lemon in their water.
        /// </value>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if (value)
                    specialinstructions.Add("Add lemon");
                lemon = value;
            }
        }

        /// <value>
        /// Gets/sets what size drink the customer wants.
        /// </value>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        /// <value>
        /// Price should always be 0, but added a set just in case.
        /// </value>
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        /// <value>
        /// Calories should always be 0, but added a set just in case.
        /// </value>
        public uint Calories
        {
            get { return calories; }
            set
            {
                calories = value;
            }
        }

        /// <value>
        /// Allows us to get/set the list of special instructions.
        /// </value>
        public List<string> SpecialInstructions
        {
            get { return specialinstructions; }
            set
            {
                specialinstructions = value;
            }
        }

        /// <summary>
        /// Overrides general ToString() to represent what size water the customer wants.
        /// </summary>
        /// <returns>"[Size] Warrior Water"</returns>
        public override string ToString()
        {
            string sizeStr = "";

            switch (size)
            {
                case Size.Small:
                    sizeStr = "Small";
                    break;
                case Size.Medium:
                    sizeStr = "Medium";
                    break;
                case Size.Large:
                    sizeStr = "Large";
                    break;
            }

            return (sizeStr + " Warrior Water");
        }
    }
}

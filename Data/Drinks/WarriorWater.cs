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
    class WarriorWater
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;
        private List<string> specialinstructions = new List<string>();
        private double price = 0;
        private uint calories = 0;

        /// <summary>
        /// Gets/sets whether the customer wants ice in their water.
        /// </summary>
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

        /// <summary>
        /// Gets/sets whether the customer wants lemon in their water.
        /// </summary>
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

        /// <summary>
        /// Gets/sets what size coffee the customer wants.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                Size = value;
            }
        }
        
        /// <summary>
        /// Price should always be 0, but added a set just in case.
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Calories should always be 0, but added a set just in case.
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set
            {
                calories = value;
            }
        }

        /// <summary>
        /// Allows us to get/set the list of special instructions.
        /// </summary>
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

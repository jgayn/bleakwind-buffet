/* Author: Jared Gaynor
 * Class: DragonBornWaffleFries.cs
 * Purpose: Is a model for information about an order of Dragonborn Waffle Fries.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of Mad Otar Grits.
    /// </summary>
    public class DragonBornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the side. </value>
        private double price = 0.42;

        /// <value> Stores and initializes the size of the side to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes the calories of the side to that of a small </value>
        private uint calories = 77;

        /// <value> Holds the special instructions (empty)</value>
        public List<string> SpecialInstructions = new List<string>();

        /// <value>Holds the size of this item</value>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// Gets/sets the price of this side based on size.
        /// </value>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        price = 0.42;
                        return price;
                    case Size.Medium:
                        price = 0.76;
                        return price;
                    case Size.Large:
                        price = 0.96;
                        return price;
                    default:
                        return price;
                }
            }
            set
            {
                switch (size)
                {
                    case Size.Small:
                        price = 0.42;
                        break;
                    case Size.Medium:
                        price = 0.76;
                        break;
                    case Size.Large:
                        price = 0.96;
                        break;
                }
            }
        }

        /// <value>
        /// Gets/sets number of calories for this side based on size.
        /// </value>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 77;
                        return calories;
                    case Size.Medium:
                        calories = 89;
                        return calories;
                    case Size.Large:
                        calories = 100;
                        return calories;
                    default:
                        return calories;
                }
            }
            set
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 77;
                        break;
                    case Size.Medium:
                        calories = 89;
                        break;
                    case Size.Large:
                        calories = 100;
                        break;
                }
            }
        }

        /// <summary>
        /// Override the general ToString() method to return a specificity about side and size.
        /// </summary>
        /// <returns>"[Size] Dragonborn Waffle Fries"</returns>
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

            return sizeStr + " Dragonborn Waffle Fries";
        }
    }
}

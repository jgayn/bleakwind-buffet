/* Author: Jared Gaynor
 * Class: VokunSalad.cs
 * Purpose: Is a model for information about an order of a Vokun Salad.
 */

using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of a Vokun Salad.
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the side. </value>
        private double price = 0.93;

        /// <value> Stores and initializes the size of the side to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes the calories of the side to that of a small </value>
        private uint calories = 41;

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
                        price = 0.93;
                        return price;
                    case Size.Medium:
                        price = 1.28;
                        return price;
                    case Size.Large:
                        price = 1.82;
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
                        price = 0.93;
                        break;
                    case Size.Medium:
                        price = 1.28;
                        break;
                    case Size.Large:
                        price = 1.82;
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
                        calories = 41;
                        return calories;
                    case Size.Medium:
                        calories = 52;
                        return calories;
                    case Size.Large:
                        calories = 73;
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
                        calories = 41;
                        break;
                    case Size.Medium:
                        calories = 52;
                        break;
                    case Size.Large:
                        calories = 73;
                        break;
                }
            }
        }

        /// <summary>
        /// Override the general ToString() method to return a specificity about side and size.
        /// </summary>
        /// <returns>"[Size] Vokun Salad"</returns>
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

            return sizeStr + " Vokun Salad";
        }
    }
}

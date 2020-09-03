/* Author: Jared Gaynor
 * Class: VokunSalad.cs
 * Purpose: Is a model for information about an order of a Vokun Salad.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of a Vokun Salad.
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private double price = 0.93;
        private Size size = Size.Small;
        private uint calories = 41;

        /// <summary>
        /// Gets/sets the price of this side based on size.
        /// </summary>
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

        /// <summary>
        /// Gets/sets number of calories for this side based on size.
        /// </summary>
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

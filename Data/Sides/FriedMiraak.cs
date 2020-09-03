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
    public class FriedMiraak
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private double price = 1.78;
        private Size size = Size.Small;
        private uint calories = 151;

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
                        price = 1.78;
                        return price;
                    case Size.Medium:
                        price = 2.01;
                        return price;
                    case Size.Large:
                        price = 2.88;
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
                        price = 1.78;
                        break;
                    case Size.Medium:
                        price = 2.01;
                        break;
                    case Size.Large:
                        price = 2.88;
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
                        calories = 151;
                        return calories;
                    case Size.Medium:
                        calories = 236;
                        return calories;
                    case Size.Large:
                        calories = 306;
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
                        calories = 151;
                        break;
                    case Size.Medium:
                        calories = 236;
                        break;
                    case Size.Large:
                        calories = 306;
                        break;
                }
            }
        }

        /// <summary>
        /// Override the general ToString() method to return a specificity about side and size.
        /// </summary>
        /// <returns>"[Size] Fried Miraak"</returns>
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

            return sizeStr + " Fried Miraak";
        }
    }
}

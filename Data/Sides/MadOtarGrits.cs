/* Author: Jared Gaynor
 * Class: MadOtarGrits.cs
 * Purpose: Is a model for information about an order of Mad Otar Grits.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of Mad Otar Grits.
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private double price = 1.22;
        private Size size = Size.Small;
        private uint calories = 105;

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
                        price = 1.22;
                        return price;
                    case Size.Medium:
                        price = 1.58;
                        return price;
                    case Size.Large:
                        price = 1.93;
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
                        price = 1.22;
                        break;
                    case Size.Medium:
                        price = 1.58;
                        break;
                    case Size.Large:
                        price = 1.93;
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
                        calories = 105;
                        return calories;
                    case Size.Medium:
                        calories = 142;
                        return calories;
                    case Size.Large:
                        calories = 179;
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
                        calories = 105;
                        break;
                    case Size.Medium:
                        calories = 142;
                        break;
                    case Size.Large:
                        calories = 179;
                        break;
                }
            }
        }

        /// <summary>
        /// Override the general ToString() method to return a specificity about side and size.
        /// </summary>
        /// <returns>"[Size] Mad Otar Grits"</returns>
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

            return sizeStr + " Mad Otar Grits";
        }
    }
}

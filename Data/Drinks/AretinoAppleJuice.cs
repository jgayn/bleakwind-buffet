/* Author: Jared Gaynor
 * Class: AretineAppleJuice.cs
 * Purpose: Is a model for information about an order of Arentino Apple Juice.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Arentino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;
        private List<string> specialinstructions = new List<string>();
        private double price = 0.62;
        private uint calories = 44;

        /// <summary>
        /// Gets/sets whether the customer wants ice in their juice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (value)
                    specialinstructions.Add("Add ice");
                ice = value;
            }
        }

        /// <summary>
        /// Gets/sets what size of juice the customer wants.
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
        /// Gets the price or sets price depending on the size of the drink.
        /// </summary>
        public double Price
        {
            get {
                switch (size)
                {
                    case Size.Small:
                        price = 0.62;
                        return price;
                    case Size.Medium:
                        price = 0.87;
                        return price;
                    case Size.Large:
                        price = 1.01;
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
                        price = 0.62;
                        break;
                    case Size.Medium:
                        price = 0.87;
                        break;
                    case Size.Large:
                        price = 1.01;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the calories or sets calories based on the size of the drink.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 44;
                        return calories;
                    case Size.Medium:
                        calories = 88;
                        return calories;
                    case Size.Large:
                        calories = 132;
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
                        calories = 44;
                        break;
                    case Size.Medium:
                        calories = 88;
                        break;
                    case Size.Large:
                        calories = 132;
                        break;
                }
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
        /// Overrides general ToString() to represent what size juice this customer is getting.
        /// </summary>
        /// <returns>"[Size] Aretine Apple Juice"</returns>
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

            return (sizeStr + " Arentino Apple Juice");
        }
    }
}

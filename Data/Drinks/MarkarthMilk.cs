/* Author: Jared Gaynor
 * Class: MarkarthMilk.cs
 * Purpose: Is a model for information about an order of Markarth's Milk.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Markarth's Milk.
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool ice = false; // a sin to put ice in milk.
        private Size size = Size.Small;
        private List<string> specialinstructions = new List<string>();
        private double price = 1.05;
        private uint calories = 56;

        /// <summary>
        /// Gets/sets whether the customer wants ICE IN THEIR MILK.
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
        /// Gets/sets what size of milk the customer wants.
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
            get
            {
                switch (size)
                {
                    case Size.Small:
                        price = 1.05;
                        return price;
                    case Size.Medium:
                        price = 1.11;
                        return price;
                    case Size.Large:
                        price = 1.22;
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
                        price = 1.05;
                        break;
                    case Size.Medium:
                        price = 1.11;
                        break;
                    case Size.Large:
                        price = 1.22;
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
                        calories = 56;
                        return calories;
                    case Size.Medium:
                        calories = 72;
                        return calories;
                    case Size.Large:
                        calories = 93;
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
                        calories = 56;
                        break;
                    case Size.Medium:
                        calories = 72;
                        break;
                    case Size.Large:
                        calories = 93;
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
        /// Overrides general ToString() to represent what size milk this customer is getting.
        /// </summary>
        /// <returns>"[Size] Markarth Milk"</returns>
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

            return (sizeStr + " Markarth Milk");
        }
    }
}

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

        /// <value>Stores whether ice is in the drink</value>
        private bool ice = false; // a sin to put ice in milk.

        /// <value> Stores and initializes the size of the drink to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value> Stores and initializes the price of the drink to that of a small </value>
        private double price = 1.05;

        /// <value> Stores and initializes the calories of the drink ot that of a small </value>
        private uint calories = 56;

        /// <value>
        /// Gets/sets whether the customer wants ICE IN THEIR MILK.
        /// </value>
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

        /// <value>
        /// Gets/sets what size of milk the customer wants.
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
        /// Gets the price or sets price depending on the size of the drink.
        /// </value>
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

        /// <value>
        /// Gets the calories or sets calories based on the size of the drink.
        /// </value>
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

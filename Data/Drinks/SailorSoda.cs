﻿/* Author: Jared Gaynor
 * Class: SailorSoda.cs
 * Purpose: Is a model for information about an order of Sailor's Soda.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Sailor's Soda.
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value>Stores whether ice is in the drink</value>
        private bool ice = true;

        /// <value>Stores what flavor the soda is</value>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <value> Stores and initializes the size of the drink to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value> Stores and initializes the price of the drink to that of a small </value>
        private double price = 1.42;

        /// <value> Stores and initializes the calories of the drink ot that of a small </value>
        private uint calories = 117;

        /// <value>
        /// Public property to get/set whether the customer wants ice in their drink.
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
        /// Public property to get/set the size of the customer's drink.
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
        /// Public property to get/set the flavor of the customer's drink.
        /// </value>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
            }
        }

        /// <value>
        /// Gets the price or sets the price of the drink based on size.
        /// </value>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        price = 1.42;
                        return price;
                    case Size.Medium:
                        price = 1.74;
                        return price;
                    case Size.Large:
                        price = 2.07;
                        return price;
                    default:
                        return price;
                }
            }
            set
            {
                switch(size)
                {
                    case Size.Small: 
                        price = 1.42;
                        break;
                    case Size.Medium:
                        price = 1.74;
                        break;
                    case Size.Large:
                        price = 2.07;
                        break;
                }
            }
        }

        /// <value>
        /// Gets the calories or sets the calories of the drink based on size.
        /// </value>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 117;
                        return calories;
                    case Size.Medium:
                        calories = 153;
                        return calories;
                    case Size.Large:
                        calories = 205;
                        return calories;
                    default:
                        return calories;
                }
            }
            set
            {
                switch(size)
                {
                    case Size.Small:
                        calories = 117;
                        break;
                    case Size.Medium:
                        calories = 153;
                        break;
                    case Size.Large:
                        calories = 205;
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
        /// Overrides general ToString() to represent this specific soda with flavor and size included.
        /// </summary>
        /// <returns>"[Size] [Flavor] Sailor Soda"</returns>
        public override string ToString()
        {
            string sizeStr = "";
            string flavStr = "";

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

            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    flavStr = "Blackberry";
                    break;
                case SodaFlavor.Cherry:
                    flavStr = "Cherry";
                    break;
                case SodaFlavor.Grapefruit:
                    flavStr = "Grapefruit";
                    break;
                case SodaFlavor.Lemon:
                    flavStr = "Lemon";
                    break;
                case SodaFlavor.Peach:
                    flavStr = "Peach";
                    break;
                case SodaFlavor.Watermelon:
                    flavStr = "Watermelon";
                    break;
            }

            return (sizeStr + " " + flavStr + " Sailor Soda");
        }
    }
}

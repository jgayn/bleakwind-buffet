/* Author: Jared Gaynor
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
    class SailorSoda
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool ice = true;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        private Size size = Size.Small;
        private List<string> specialinstructions = new List<string>();
        private double price = 1.42;
        private uint calories = 117;

        /// <summary>
        /// Public property to get/set whether the customer wants ice in their drink.
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
        /// Public property to get/set the size of the customer's drink.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Public property to get/set the flavor of the customer's drink.
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets the price or sets the price of the drink based on size.
        /// </summary>
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

        /// <summary>
        /// Gets the calories or sets the calories of the drink based on size.
        /// </summary>
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

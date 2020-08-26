/* Author: Jared Gaynor
 * Class: CandlehearthCoffee.cs
 * Purpose: Is a model for information about an order of Candlehearth Coffee.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Candlehearth Coffee
    /// </summary>
    class CandlehearthCoffee
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;
        private List<string> specialinstructions = new List<string>();
        private double price = 0.75;
        private uint calories = 7;

        /// <summary>
        /// Gets/sets whether the customer wants ice in their coffee.
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
        /// Gets/sets whether there is room for cream in their coffee!
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (value)
                    specialinstructions.Add("Add cream");
                roomForCream = value;
            }
        }

        /// <summary>
        /// Gets/sets whether the customer wants their coffee decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// Gets/sets what size coffee the customer wants.
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
                        price = 0.75;
                        return price;
                    case Size.Medium:
                        price = 1.25;
                        return price;
                    case Size.Large:
                        price = 1.75;
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
                        price = 0.75;
                        break;
                    case Size.Medium:
                        price = 1.25;
                        break;
                    case Size.Large:
                        price = 1.75;
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
                        calories = 7;
                        return calories;
                    case Size.Medium:
                        calories = 10;
                        return calories;
                    case Size.Large:
                        calories = 20;
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
                        calories = 7;
                        break;
                    case Size.Medium:
                        calories = 10;
                        break;
                    case Size.Large:
                        calories = 20;
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
        /// Overrides general ToString() to represent what size and decaf/caf coffee this customer is getting.
        /// </summary>
        /// <returns>"[Size] [Decaf/""] Candlehearth Coffee"</returns>
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

            if (decaf)
            {
                return (sizeStr + " Decaf Candlehearth Coffee");
            }
            else
            {
                return (sizeStr + " Candlehearth Coffee");
            }
        }
    }
}

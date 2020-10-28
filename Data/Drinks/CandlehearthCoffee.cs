/* Author: Jared Gaynor
 * Class: CandlehearthCoffee.cs
 * Purpose: Is a model for information about an order of Candlehearth Coffee.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds information about an order of Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value>Stores whether ice is in the drink</value>
        private bool ice = false;

        /// <value> Stores whether the drink is decaf </value>
        private bool decaf = false;

        /// <value> Stores whether the drink has cream </value>
        private bool roomForCream = false;

        /// <value> Stores and initializes the size of the drink to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value> Stores and initializes the price of the drink to that of a small </value>
        private double price = 0.75;

        /// <value> Stores and initializes the calories of the drink ot that of a small </value>
        private uint calories = 7;

        /// <value>
        /// Gets/sets whether the customer wants ice in their coffee.
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (value)
                    specialinstructions.Add("Add ice");
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <value>
        /// Gets/sets whether there is room for cream in their coffee!
        /// </value>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (value)
                    specialinstructions.Add("Add cream");
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
            }
        }

        /// <value>
        /// Gets/sets whether the customer wants their coffee decaf.
        /// </value>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <value>
        /// Gets/sets what size coffee the customer wants.
        /// </value>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <value>
        /// Gets the price or sets price depending on the size of the drink.
        /// </value>
        public override double Price
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
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Medium:
                        price = 1.25;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Large:
                        price = 1.75;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                }
            }
        }

        /// <value>
        /// Gets the calories or sets calories based on the size of the drink.
        /// </value>
        public override uint Calories
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
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Medium:
                        calories = 10;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Large:
                        calories = 20;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                }
            }
        }

        /// <value>
        /// Allows us to get/set the list of special instructions.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get { return specialinstructions; }
            set
            {
                specialinstructions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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

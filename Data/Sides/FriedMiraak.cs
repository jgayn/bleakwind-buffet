﻿/* Author: Jared Gaynor
 * Class: VokunSalad.cs
 * Purpose: Is a model for information about an order of a Vokun Salad.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of a Vokun Salad.
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 1.78;

        /// <value> Stores and initializes the size of the side to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes the calories of the side to that of a small </value>
        private uint calories = 151;

        /// <value> Holds the special instructions (empty)</value>
        public override List<string> SpecialInstructions
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets the description of the item
        /// </summary>
        public override string Description
        {
            get { return "Perfectly prepared hash brown pancakes."; }
        }

        /// <value>Holds the size of this item</value>
        public override Size Size
        {
            get { return size; }
            set { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <value>
        /// Gets/sets the price of this side based on size.
        /// </value>
        public override double Price
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
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Medium:
                        price = 2.01;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Large:
                        price = 2.88;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                }
            }
        }

        /// <value>
        /// Gets/sets number of calories for this side based on size.
        /// </value>
        public override uint Calories
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
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Medium:
                        calories = 236;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Large:
                        calories = 306;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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

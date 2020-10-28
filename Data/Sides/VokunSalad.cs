/* Author: Jared Gaynor
 * Class: VokunSalad.cs
 * Purpose: Is a model for information about an order of a Vokun Salad.
 */

using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds information for an order of a Vokun Salad.
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the side. </value>
        private double price = 0.93;

        /// <value> Stores and initializes the size of the side to small </value>
        private Size size = Size.Small;

        /// <value> Stores and initializes the calories of the side to that of a small </value>
        private uint calories = 41;

        /// <value> Holds the special instructions (empty)</value>
        public override List<string> SpecialInstructions
        {
            get;
            set;
        } = new List<string>();

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
                        price = 0.93;
                        return price;
                    case Size.Medium:
                        price = 1.28;
                        return price;
                    case Size.Large:
                        price = 1.82;
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
                        price = 0.93;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Medium:
                        price = 1.28;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        break;
                    case Size.Large:
                        price = 1.82;
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
                        calories = 41;
                        return calories;
                    case Size.Medium:
                        calories = 52;
                        return calories;
                    case Size.Large:
                        calories = 73;
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
                        calories = 41;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Medium:
                        calories = 52;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                    case Size.Large:
                        calories = 73;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        break;
                }
            }
        }

        /// <summary>
        /// Override the general ToString() method to return a specificity about side and size.
        /// </summary>
        /// <returns>"[Size] Vokun Salad"</returns>
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

            return sizeStr + " Vokun Salad";
        }
    }
}

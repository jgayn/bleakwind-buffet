/* Author: Jared Gaynor
 * Class: PhillyPoacher.cs
 * Purpose: Is a model for information about the entree "Philly Poacher"
 * 
 * 
 * I am from philly, this item better be the best on the menu. (also ribeye > sirloin)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Philly Poacher.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 7.23;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 784;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value> Stores and initializes whether sirloin is included in the order to true. </value>
        private bool sirloin = true;

        /// <value> Stores and initializes whether onion is included in the order to true. </value>
        private bool onions = true;

        /// <value> Stores and initializes whether a roll is included in the order to true. </value>
        private bool roll = true;

        /// <value>
        /// Public property for whether or not customer wants sirloin steak.
        /// Can get value or set a new value.
        /// </value>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold sirloin");
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants onions.
        /// Can get value or set a new value.
        /// </value>
        public bool Onions
        {
            get { return onions; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold onions");
                onions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onions"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants a roll.
        /// Can get value or set a new value.
        /// </value>
        public bool Roll
        {
            get { return roll; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold roll");
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }

        /// <value>
        /// Public property to return the price of this entree.
        /// </value>
        public override double Price
        {
            get { return price; }
            set { 
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <value>
        /// Public property to return the amount of calories in this entree.
        /// </value>
        public override uint Calories
        {
            get { return calories; }
            set { 
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <value>
        /// Returns a list of special instructions the customer can give.
        /// </value>
        public override List<string> SpecialInstructions
        {
            get { return specialinstructions; }
            set { 
                SpecialInstructions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstrucions"));
            }
        }

        /// <summary>
        /// Overrides the ToString() to return the name of the entree and not a garbage value.
        /// </summary>
        /// <returns>The name of this entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

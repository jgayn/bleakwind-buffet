/* Author: Jared Gaynor
 * Class: ThalmorTriple.cs
 * Purpose: Is a model for information about the entree "Thalmor Triple"
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Thalmor Triple.
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes whether a bun is included in the order to true. </value>
        private bool bun = true;

        /// <value> Stores and initializes whether ketchup is included in the order to true. </value>
        private bool ketchup = true;

        /// <value> Stores and initializes whether mustard is included in the order to true. </value>
        private bool mustard = true;

        /// <value> Stores and initializes whether pickle is included in the order to true. </value>
        private bool pickle = true;

        /// <value> Stores and initializes whether cheese is included in the order to true. </value>
        private bool cheese = true;

        /// <value> Stores and initializes whether tomato is included in the order to true. </value>
        private bool tomato = true;

        /// <value> Stores and initializes whether lettuce is included in the order to true. </value>
        private bool lettuce = true;

        /// <value> Stores and initializes whether mayo is included in the order to true. </value>
        private bool mayo = true;

        /// <value> Stores and initializes whether bacon is included in the order to true. </value>
        private bool bacon = true;

        /// <value> Stores and initializes whether egg is included in the order to true. </value>
        private bool egg = true;

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 8.32;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 943;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value>
        /// Public property for whether or not customer wants a bun.
        /// Can get value or set a new value.
        /// </value>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold bun");
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants ketchup.
        /// Can get value or set a new value.
        /// </value>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold ketchup");
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants mustard.
        /// Can get value or set a new value.
        /// </value>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mustard");
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants pickles.
        /// Can get value or set a new value.
        /// </value>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold pickle");
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants cheese.
        /// Can get value or set a new value.
        /// </value>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold cheese");
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants tomato.
        /// Can get value or set a new value.
        /// </value>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold tomato");
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants lettuce.
        /// Can get value or set a new value.
        /// </value>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold lettuce");
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants mayo.
        /// Can get value or set a new value.
        /// </value>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mayo");
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants bacon.
        /// Can get value or set a new value.
        /// </value>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold bacon");
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
            }
        }

        /// <value>
        /// Public property for whether or not customer wants an egg.
        /// Can get value or set a new value.
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold egg");
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Overrides the ToString() to return the name of the entree and not a garbage value.
        /// </summary>
        /// <returns>The name of this entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

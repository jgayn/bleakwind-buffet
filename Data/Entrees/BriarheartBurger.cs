/* Author: Jared Gaynor
 * Class: BriarheartBurger.cs
 * Purpose: Is a model for information about the entree "Briarheart Burger"
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Briarheart Burger.
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        
        /// <value> Stores and initializes whether a bun is included in the order to true. </value>
        private bool bun = true;

        /// <value> Stores and initializes whether ketchup is included in the order to true. </value>
        private bool ketchup = true;

        /// <value> Stores and initializes whether mustard is included in the order to true. </value>
        private bool mustard = true;

        /// <value> Stores and initializes whether pickles are included in the order to true. </value>
        private bool pickle = true;

        /// <value> Stores and initializes whether cheese is included in the order to true. </value>
        private bool cheese = true;

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 6.32;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 743;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value>
        /// Public property for whether or not customer wants a bun.
        /// Can get value or set a new value.
        /// </value>
        public bool Bun {
            get { return bun; }
            set {
                if (!value)
                    specialinstructions.Add("Hold bun");
                bun = value; 
            } 
        }

        /// <value>
        /// Public property for whether or not customer wants ketchup.
        /// Can get value or set a new value.
        /// </value>
        public bool Ketchup {
            get { return ketchup; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold ketchup");
                ketchup = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants mustard.
        /// Can get value or set a new value.
        /// </value>
        public bool Mustard {
            get { return mustard; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mustard");
                mustard = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants pickles.
        /// Can get value or set a new value.
        /// </value>
        public bool Pickle {
            get { return pickle; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold pickle");
                pickle = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants cheese.
        /// Can get value or set a new value.
        /// </value>
        public bool Cheese {
            get { return cheese; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold cheese");
                cheese = value;
            }
        }

        /// <value>
        /// Public property to return the price of the burger.
        /// </value>
        public double Price
        {
            get { return price; }
        }

        /// <value>
        /// Public property to return the amount of calories in the burger.
        /// </value>
        public uint Calories
        {
            get { return calories; }
        }

        /// <value>
        /// Returns a list of special instructions the customer can give.
        /// </value>
        public List<string> SpecialInstructions
        {
            get { return specialinstructions; }
        }

        /// <summary>
        /// Overrides the ToString() to return the name of the entree and not a garbage value.
        /// </summary>
        /// <returns>The name of this entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}

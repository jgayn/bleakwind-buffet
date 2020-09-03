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
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private double price = 6.32;
        private uint calories = 743;
        private List<string> specialinstructions = new List<string>();

        /// <summary>
        /// Public property for whether or not customer wants a bun.
        /// Can get value or set a new value.
        /// </summary>
        public bool Bun {
            get { return bun; }
            set {
                if (!value)
                    specialinstructions.Add("Hold bun");
                bun = value; 
            } 
        }

        /// <summary>
        /// Public property for whether or not customer wants ketchup.
        /// Can get value or set a new value.
        /// </summary>
        public bool Ketchup {
            get { return ketchup; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold ketchup");
                ketchup = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants mustard.
        /// Can get value or set a new value.
        /// </summary>
        public bool Mustard {
            get { return mustard; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mustard");
                mustard = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants pickles.
        /// Can get value or set a new value.
        /// </summary>
        public bool Pickle {
            get { return pickle; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold pickle");
                pickle = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants cheese.
        /// Can get value or set a new value.
        /// </summary>
        public bool Cheese {
            get { return cheese; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold cheese");
                cheese = value;
            }
        }

        /// <summary>
        /// Public property to return the price of the burger.
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Public property to return the amount of calories in the burger.
        /// </summary>
        public uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Returns a list of special instructions the customer can give.
        /// </summary>
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

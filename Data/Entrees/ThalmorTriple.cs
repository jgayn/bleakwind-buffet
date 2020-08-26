﻿/* Author: Jared Gaynor
 * Class: ThalmorTriple.cs
 * Purpose: Is a model for information about the entree "Thalmor Triple"
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Thalmor Triple.
    /// </summary>
    class ThalmorTriple
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;
        private double price = 8.32;
        private uint calories = 943;
        private List<string> specialinstructions = new List<string>();

        /// <summary>
        /// Public property for whether or not customer wants a bun.
        /// Can get value or set a new value.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold bun");
                bun = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants ketchup.
        /// Can get value or set a new value.
        /// </summary>
        public bool Ketchup
        {
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
        public bool Mustard
        {
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
        public bool Pickle
        {
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
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold cheese");
                cheese = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants tomato.
        /// Can get value or set a new value.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold tomato");
                tomato = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants lettuce.
        /// Can get value or set a new value.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold lettuce");
                lettuce = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants mayo.
        /// Can get value or set a new value.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mayo");
                mayo = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants bacon.
        /// Can get value or set a new value.
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold bacon");
                bacon = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants an egg.
        /// Can get value or set a new value.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold egg");
                egg = value;
            }
        }

        /// <summary>
        /// Public property to return the price of this burger.
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Public property to return the amount of calories in this burger.
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
            return "Thalmor Triple";
        }
    }
}
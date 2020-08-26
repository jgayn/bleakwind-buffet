/* Author: Jared Gaynor
 * Class: GardenOrcOmelette.cs
 * Purpose: Is a model for information about the entree "Garden Orc Omelette"
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Garden Orc Omelette.
    /// </summary>
    class GardenOrcOmelette
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool brocolli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;
        private double price = 4.57;
        private uint calories = 404;
        private List<string> specialinstructions = new List<string>();

        /// <summary>
        /// Public property for whether or not customer wants brocolli.
        /// Can get value or set a new value.
        /// </summary>
        public bool Brocolli
        {
            get { return brocolli; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold brocolli");
                brocolli = value;
            }
        }

        /// <summary>
        /// Public property for whether or not customer wants mushrooms.
        /// Can get value or set a new value.
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold mushrooms");
                mushrooms = value;
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
        /// Public property for whether or not customer wants cheddar cheese.
        /// Can get value or set a new value.
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold cheddar");
                cheddar = value;
            }
        }

        /// <summary>
        /// Public property to return the price of this entree.
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Public property to return the amount of calories in this entree.
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
            return "Garden Orc Omelette";
        }
    }
}

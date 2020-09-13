/* Author: Jared Gaynor
 * Class: GardenOrcOmelette.cs
 * Purpose: Is a model for information about the entree "Garden Orc Omelette"
 */

using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Garden Orc Omelette.
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes whether brocolli is included in the order to true. </value>
        private bool brocolli = true;

        /// <value> Stores and initializes whether mushrooms are included in the order to true. </value>
        private bool mushrooms = true;

        /// <value> Stores and initializes whether tomato is included in the order to true. </value>
        private bool tomato = true;

        /// <value> Stores and initializes whether cheddar cheese is included in the order to true. </value>
        private bool cheddar = true;

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 4.57;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 404;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value>
        /// Public property for whether or not customer wants brocolli.
        /// Can get value or set a new value.
        /// </value>
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

        /// <value>
        /// Public property for whether or not customer wants mushrooms.
        /// Can get value or set a new value.
        /// </value>
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
            }
        }

        /// <value>
        /// Public property for whether or not customer wants cheddar cheese.
        /// Can get value or set a new value.
        /// </value>
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

        /// <value>
        /// Public property to return the price of this entree.
        /// </value>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <value>
        /// Public property to return the amount of calories in this entree.
        /// </value>
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        /// <value>
        /// Returns a list of special instructions the customer can give.
        /// </value>
        public List<string> SpecialInstructions
        {
            get { return specialinstructions; }
            set { SpecialInstructions = value; }
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

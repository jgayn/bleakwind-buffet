﻿/* Author: Jared Gaynor
 * Class: SmokehouseSkeleton.cs
 * Purpose: Is a model for information about the entree "Smokehouse Skeleton"
 */

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Smokehouse Skeleton.
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes whether sausage is included in the order to true. </value>
        private bool sausagelink = true;

        /// <value> Stores and initializes whether egg is included in the order to true. </value>
        private bool egg = true;

        /// <value> Stores and initializes whether hashbrowns are included in the order to true. </value>
        private bool hashbrowns = true;

        /// <value> Stores and initializes whether pancakes are included in the order to true. </value>
        private bool pancake = true;

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 5.62;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 602;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>();

        /// <value>
        /// Public property for whether or not customer wants sausage.
        /// Can get value or set a new value.
        /// </value>
        public bool SausageLink
        {
            get { return sausagelink; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold sausage");
                sausagelink = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants eggs.
        /// Can get value or set a new value.
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold eggs");
                egg = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants hash browns.
        /// Can get value or set a new value.
        /// </value>
        public bool HashBrowns
        {
            get { return hashbrowns; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold hash browns");
                hashbrowns = value;
            }
        }

        /// <value>
        /// Public property for whether or not customer wants pancakes.
        /// Can get value or set a new value.
        /// </value>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                if (!value)
                    specialinstructions.Add("Hold pancakes");
                pancake = value;
            }
        }

        /// <value>
        /// Public property to return the price of this entree.
        /// </value>
        public double Price
        {
            get { return price; }
        }

        /// <value>
        /// Public property to return the amount of calories in this entree.
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
            return "Smokehouse Skeleton";
        }
    }
}

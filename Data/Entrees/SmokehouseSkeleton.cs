/* Author: Jared Gaynor
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
    class SmokehouseSkeleton
    {
        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>
        private bool sausagelink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;
        private double price = 5.62;
        private uint calories = 602;
        private List<string> specialinstructions = new List<string>();

        /// <summary>
        /// Public property for whether or not customer wants sausage.
        /// Can get value or set a new value.
        /// </summary>
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

        /// <summary>
        /// Public property for whether or not customer wants eggs.
        /// Can get value or set a new value.
        /// </summary>
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

        /// <summary>
        /// Public property for whether or not customer wants hash browns.
        /// Can get value or set a new value.
        /// </summary>
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

        /// <summary>
        /// Public property for whether or not customer wants pancakes.
        /// Can get value or set a new value.
        /// </summary>
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
            return "Smokehouse Skeleton";
        }
    }
}

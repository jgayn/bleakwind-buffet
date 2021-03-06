﻿/* Author: Jared Gaynor
 * Class: ThugsTBone.cs
 * Purpose: Is a model for information about the entree "Thug's T-Bone"
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds information about an order of the Thug's T-Bone.
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creation of various private backing variables used in public properties.
        /// </summary>

        /// <value> Stores and initializes the price of the meal. </value>
        private double price = 6.44;

        /// <value> Stores and initializes the calories of the meal. </value>
        private uint calories = 982;

        /// <value> Stores and initializes special instructions for the order to an empty list </value>
        private List<string> specialinstructions = new List<string>(); // always empty

        /// <value>
        /// Public property to return the price of this entree.
        /// </value>
        public override double Price
        {
            get { return price; }
            set { 
                price = value;
            }
        }

        /// <summary>
        /// Gets the description of the item
        /// </summary>
        public override string Description
        {
            get { return "Juicy T-Bone, not much else to say."; }
        }

        /// <value>
        /// Public property to return the amount of calories in this entree.
        /// </value>
        public override uint Calories
        {
            get { return calories; }
            set { 
                calories = value;
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
            }
        }

        /// <summary>
        /// Overrides the ToString() to return the name of the entree and not a garbage value.
        /// </summary>
        /// <returns>The name of this entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

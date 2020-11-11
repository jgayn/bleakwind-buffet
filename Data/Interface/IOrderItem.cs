using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Interface that implements price, calories, and special instructions for ordering items
    /// </summary>
    public interface IOrderItem
    {
        /// <value>
        /// Public property to access/set price of item
        /// </value>
        double Price
        {
            get;
            set;
        }

        /// <value>
        /// Public property to access/set calories of an item
        /// </value>
        uint Calories
        {
            get;
            set;
        }

        /// <summary>
        /// Public property to access/set special instructions
        /// </summary>
        List<string> SpecialInstructions
        {
            get;
            set;
        }

        /// <summary>
        /// Public property to access description
        /// </summary>
        string Description
        {
            get;
        }
    }
}

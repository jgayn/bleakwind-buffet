using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Website
{
    public static class ItemFilter
    {

        /// <summary>
        /// Private backing variable for items
        /// </summary>
        private static List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Holds types of items that can be ordered
        /// </summary>
        public static string[] ItemType
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }

        static ItemFilter()
        {
            items = Menu.FullMenu().ToList();
        }

        /// <summary>
        /// Public facing variable for current list of items corresponding to the search
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return items; } }

        /// <summary>
        /// Searches current list of items and returns a list with items containing the given string
        /// </summary>
        /// <param name="terms">Search terms</param>
        /// <returns>List of items with names containing the search term</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> list, string terms)
        {
            if (terms == null)
            {
                return All; 
            }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in All)
            {
                if (item.ToString().Contains(terms, StringComparison.CurrentCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given list by the given types of items
        /// </summary>
        /// <param name="list">List to filter</param>
        /// <param name="types">List of selected types</param>
        /// <returns>Filtered list based on given types</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> list, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0)
            {
                return list;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in list)
            {
                if(item is Entree)
                {
                    if (types.Contains("Entree"))
                    {
                        results.Add(item);
                    }
                }

                else if(item is Drink)
                {
                    if (types.Contains("Drink"))
                    {
                        results.Add(item);
                    }
                }

                else if(item is Side)
                {
                    if (types.Contains("Side"))
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given list by minimum and maximum price given
        /// </summary>
        /// <param name="list">List to filter</param>
        /// <param name="min">Minimum price given</param>
        /// <param name="max">Maximum price given</param>
        /// <returns>Filtered list by given prices</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            if (min == null && max == null)
            {
                return list;
            }

            if (min == 0 && max == 0)
            {
                return list;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in list)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach(IOrderItem item in list)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given list by min/max calories
        /// </summary>
        /// <param name="list">List to filter</param>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        /// <returns>Filtered list by given calories</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            if (min == null && max == null)
            {
                return list;
            }

            if (min == 0 && max == 0)
            {
                return list;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in list)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}

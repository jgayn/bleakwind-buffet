using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */

        /// <summary>
        /// Holds the current search string
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Holds the three types of items: Drink, Entree, Side
        /// </summary>
        public string[] ItemTypes { get; set; } = new string[3];

        /// <summary>
        /// Holds the current list of items that correspond with the search.
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; } = Menu.FullMenu();

        /// <summary>
        /// REST method, called whenever a GET request is made
        /// </summary>
        public void OnGet(string SearchTerms, string[] ItemTypes, double? MaxPrice, double? MinPrice, double? MaxCalories, double? MinCalories)
        {
            /*
            Items = ItemFilter.Search(Items, SearchTerms);
            Items = ItemFilter.FilterByType(Items, ItemTypes);
            Items = ItemFilter.FilterByPrice(Items, MinPrice, MaxPrice);
            Items = ItemFilter.FilterByCalories(Items, MinCalories, MaxCalories);
            */

            Items = Menu.FullMenu();

            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && (item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || 
                    item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)));
            }

            if (ItemTypes != null && ItemTypes.Length != 0)
            {
                Items = Items.Where(item =>
                    item is Entree && ItemTypes.Contains("Entree") ||
                    item is Drink && ItemTypes.Contains("Drink") ||
                    item is Side && ItemTypes.Contains("Side")
                    );
            }

            if ( !(MinPrice == null && MaxPrice == null) && !(MinPrice == 0 && MaxPrice == 0) )
            {
                Items = Items.Where(item => item.Price >= MinPrice && item.Price <= MaxPrice);   
            }

            if (!(MinCalories == null && MaxCalories == null) && !(MinCalories == 0 && MaxCalories == 0))
            {
                Items = Items.Where(item => item.Calories >= MinCalories && item.Calories <= MaxCalories);
            }
        }
    }
}

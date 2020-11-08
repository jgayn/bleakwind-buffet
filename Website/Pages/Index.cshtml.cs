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
        public void OnGet(string SearchTerms, string[] ItemTypes, double MaxPrice, double MinPrice, double MaxCalories, double MinCalories)
        {
            Items = ItemFilter.Search(Items, SearchTerms);
            Items = ItemFilter.FilterByType(Items, ItemTypes);
            Items = ItemFilter.FilterByPrice(Items, MinPrice, MaxPrice);
            Items = ItemFilter.FilterByCalories(Items, MinCalories, MaxCalories);
        }
    }
}

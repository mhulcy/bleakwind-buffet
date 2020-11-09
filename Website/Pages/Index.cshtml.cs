using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace Website.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        private bool isFirstRun = true;

        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered FoodTypes
        /// </summary>
        public string[] FoodTypes { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
            FoodTypes = new string[3];
        }

        

        public void OnGet(string SearchTerms, string[] FoodTypes, double ?PriceMin, double ?PriceMax, double ?CaloriesMin, double ?CaloriesMax) {                            //string SearchTerms, string[] FoodTypes, double PriceMin, double PriceMax, double CaloriesMin, double CaloriesMax
            
            OrderItems = Menu.Search(SearchTerms);
            OrderItems = Menu.FilterByFoodType(OrderItems, FoodTypes);
            
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);

        }
    }
}

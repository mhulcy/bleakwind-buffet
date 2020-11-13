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
            OrderItems = Menu.FullMenu();
            
            // Search movie titles for the SearchTerms
            if (SearchTerms != null) {
                OrderItems = OrderItems.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            // Filter by FoodType
            if (FoodTypes != null && FoodTypes.Length != 0) {
                OrderItems = OrderItems.Where(item =>
                    item.FoodType != null &&
                    FoodTypes.Contains(item.FoodType)
                    );
            }
            // Filter by Price
            if (PriceMin != null || PriceMax != null) {
                if (PriceMin == null) {
                    OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
                }
                else if (PriceMax == null) {
                    OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
                }
                else {
                    OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
                    OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
                }
            }
            // Filter by Calories
            if (CaloriesMin != null || CaloriesMax != null) {
                if (CaloriesMin == null) {
                    OrderItems = OrderItems.Where(item => item.Calories <= CaloriesMax);
                }
                else if (PriceMax == null) {
                    OrderItems = OrderItems.Where(item => item.Calories >= CaloriesMin);
                }
                else {
                    OrderItems = OrderItems.Where(item => item.Calories <= CaloriesMax);
                    OrderItems = OrderItems.Where(item => item.Calories >= CaloriesMin);
                }
            }


        }
    }
}

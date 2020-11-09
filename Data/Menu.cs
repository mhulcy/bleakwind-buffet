using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data {
    public static class Menu {

        /// <summary>
        /// Gets the possible MPAARatings
        /// </summary>
        public static string[] FoodTypes {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }
        /// <summary>
        /// Lists out all entrees on menu
        /// </summary>
        /// <returns>a list of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees() {
            IOrderItem[] entrees = new IOrderItem[] { new BriarheartBurger(), new DoubleDraugr(), new GardenOrcOmlette(), new PhillyPoacher(), new SmokehouseSkeleton(), new ThalmorTriple(), new ThugsTBone() };
            return entrees;
        }
        /// <summary>
        /// Lists out all sides on menu
        /// </summary>
        /// <returns>a list of sides</returns>
        public static IEnumerable<IOrderItem> Sides() {
            IOrderItem[] sides = new IOrderItem[] { new DragonbornWaffleFries(Enums.Size.Small), new DragonbornWaffleFries(Enums.Size.Medium), new DragonbornWaffleFries(Size.Large), new FriedMiraak(), new FriedMiraak(Size.Medium), new FriedMiraak(Size.Large), new MadOtarGrits(), new MadOtarGrits(Size.Medium), new MadOtarGrits(Size.Large), new VolkunSalad(), new VolkunSalad(Size.Medium), new VolkunSalad(Size.Large) };
            return sides;
        }
        /// <summary>
        /// Lists out all drinks on menu
        /// </summary>
        /// <returns>a list of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks() {
            IOrderItem[] drinks = new IOrderItem[] { new AretinoAppleJuice(), new AretinoAppleJuice(Size.Medium), new AretinoAppleJuice(Size.Large), new CandlehearthCoffee(), new CandlehearthCoffee(Size.Medium), new CandlehearthCoffee(Size.Large), new MarkarthMilk(), new MarkarthMilk(Size.Medium), new MarkarthMilk(Size.Large), new SailorSoda(), new SailorSoda(Size.Small, SodaFlavor.Lemon), new SailorSoda(Size.Small, SodaFlavor.Grapefruit), new SailorSoda(Size.Small, SodaFlavor.Peach), new SailorSoda(Size.Small, SodaFlavor.Watermelon), new SailorSoda(Size.Small, SodaFlavor.Blackberry), new SailorSoda(Size.Medium, SodaFlavor.Cherry), new SailorSoda(Size.Medium, SodaFlavor.Lemon), new SailorSoda(Size.Medium, SodaFlavor.Grapefruit), new SailorSoda(Size.Medium, SodaFlavor.Peach), new SailorSoda(Size.Medium, SodaFlavor.Watermelon), new SailorSoda(Size.Medium, SodaFlavor.Blackberry), new SailorSoda(Size.Large, SodaFlavor.Cherry), new SailorSoda(Size.Large, SodaFlavor.Lemon), new SailorSoda(Size.Large, SodaFlavor.Grapefruit), new SailorSoda(Size.Large, SodaFlavor.Peach), new SailorSoda(Size.Large, SodaFlavor.Watermelon), new SailorSoda(Size.Large, SodaFlavor.Blackberry), new WarriorWater(), new WarriorWater(Size.Medium), new WarriorWater(Size.Large) };
            return drinks;
        }
        /// <summary>
        /// Lists out all items on menu
        /// </summary>
        /// <returns>a list of items</returns>
        public static IEnumerable<IOrderItem> FullMenu() {
            IOrderItem[] items = new IOrderItem[] { new BriarheartBurger(), new DoubleDraugr(), new GardenOrcOmlette(), new PhillyPoacher(), new SmokehouseSkeleton(), new ThalmorTriple(), new ThugsTBone(), new DragonbornWaffleFries(Enums.Size.Small), new DragonbornWaffleFries(Enums.Size.Medium), new DragonbornWaffleFries(Size.Large), new FriedMiraak(), new FriedMiraak(Size.Medium), new FriedMiraak(Size.Large), new MadOtarGrits(), new MadOtarGrits(Size.Medium), new MadOtarGrits(Size.Large), new VolkunSalad(), new VolkunSalad(Size.Medium), new VolkunSalad(Size.Large), new AretinoAppleJuice(), new AretinoAppleJuice(Size.Medium), new AretinoAppleJuice(Size.Large), new CandlehearthCoffee(), new CandlehearthCoffee(Size.Medium), new CandlehearthCoffee(Size.Large), new MarkarthMilk(), new MarkarthMilk(Size.Medium), new MarkarthMilk(Size.Large), new SailorSoda(), new SailorSoda(Size.Small, SodaFlavor.Lemon), new SailorSoda(Size.Small, SodaFlavor.Grapefruit), new SailorSoda(Size.Small, SodaFlavor.Peach), new SailorSoda(Size.Small, SodaFlavor.Watermelon), new SailorSoda(Size.Small, SodaFlavor.Blackberry), new SailorSoda(Size.Large, SodaFlavor.Cherry), new SailorSoda(Size.Large, SodaFlavor.Lemon), new SailorSoda(Size.Large, SodaFlavor.Grapefruit), new SailorSoda(Size.Large, SodaFlavor.Peach), new SailorSoda(Size.Large, SodaFlavor.Watermelon), new SailorSoda(Size.Large, SodaFlavor.Blackberry), new SailorSoda(Size.Large, SodaFlavor.Cherry), new SailorSoda(Size.Large, SodaFlavor.Lemon), new SailorSoda(Size.Large, SodaFlavor.Grapefruit), new SailorSoda(Size.Large, SodaFlavor.Peach), new SailorSoda(Size.Large, SodaFlavor.Watermelon), new SailorSoda(Size.Large, SodaFlavor.Blackberry), new WarriorWater(), new WarriorWater(Size.Medium), new WarriorWater(Size.Large) };
            return items;
        }
        /// <summary>
        /// Searches the database for matching order items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of order items</returns>
        public static IEnumerable<IOrderItem> Search(string terms) {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return FullMenu();

            foreach (IOrderItem item in FullMenu()) {
                if (item.ToString().Contains(terms)) { //StringComparison.InvariantCultureIgnoreCase)
                    results.Add(item);
                }
            }
            return results;
        }

        // <summary>
        /// Filters the provided collection of foodTypes
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByFoodType(IEnumerable<IOrderItem> items, IEnumerable<string> foodTypes) {

            if (foodTypes == null || foodTypes.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items) {
                if (item.FoodType != null && foodTypes.Contains(item.FoodType)) {
                    results.Add(item);
                }
            }

            return results;

        }
        /// <summary>
        /// Filters the order items within a certian price range
        /// </summary>
        /// <param name="movies">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max) {

            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null) {
                foreach (IOrderItem item in items) {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null) {
                foreach (IOrderItem item in items) {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items) {
                if (item.Price >= min && item.Price <= max) {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the order items within a certian calorie range
        /// </summary>
        /// <param name="movies">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max) {

            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null) {
                foreach (IOrderItem item in items) {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null) {
                foreach (IOrderItem item in items) {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items) {
                if (item.Calories >= min && item.Calories <= max) {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}

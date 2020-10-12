using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data {
    public static class Menu {
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
            IOrderItem[] drinks = new IOrderItem[] { new AretinoAppleJuice(), new AretinoAppleJuice(Size.Medium), new AretinoAppleJuice(Size.Large), new CandlehearthCoffee(), new CandlehearthCoffee(Size.Medium), new CandlehearthCoffee(Size.Large), new MarkarthMilk(), new MarkarthMilk(Size.Medium), new MarkarthMilk(Size.Large), new SailorSoda(), new SailorSoda(Size.Small, SodaFlavor.Lemon), new SailorSoda(Size.Small, SodaFlavor.Grapefruit), new SailorSoda(Size.Small, SodaFlavor.Peach), new SailorSoda(Size.Small, SodaFlavor.Watermelon), new SailorSoda(Size.Small, SodaFlavor.Blackberry), new SailorSoda(Size.Large, SodaFlavor.Cherry), new SailorSoda(Size.Large, SodaFlavor.Lemon), new SailorSoda(Size.Large, SodaFlavor.Grapefruit), new SailorSoda(Size.Large, SodaFlavor.Peach), new SailorSoda(Size.Large, SodaFlavor.Watermelon), new SailorSoda(Size.Large, SodaFlavor.Blackberry), new SailorSoda(Size.Large, SodaFlavor.Cherry), new SailorSoda(Size.Large, SodaFlavor.Lemon), new SailorSoda(Size.Large, SodaFlavor.Grapefruit), new SailorSoda(Size.Large, SodaFlavor.Peach), new SailorSoda(Size.Large, SodaFlavor.Watermelon), new SailorSoda(Size.Large, SodaFlavor.Blackberry), new WarriorWater(), new WarriorWater(Size.Medium), new WarriorWater(Size.Large) };
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
    }
}

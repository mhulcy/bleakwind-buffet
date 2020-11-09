﻿using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;
using BleakwindBuffet.Data.Sides;
using System.Linq;
//using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTest {
    public class MenuTests {
        [Fact]
        public void EntreeMenuShouldHaveAllEntrees() {
            IEnumerable<IOrderItem> items = Menu.Entrees();

            Assert.Collection(items,
                item => {
                    Assert.Equal(item.ToString(), new BriarheartBurger().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new DoubleDraugr().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new GardenOrcOmlette().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new PhillyPoacher().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SmokehouseSkeleton().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new ThalmorTriple().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new ThugsTBone().ToString());
                });
        }
        [Fact]
        public void SideMenuShouldHaveAllEntrees() {
            IEnumerable<IOrderItem> items = Menu.Sides();

            Assert.Collection(items,
                item => {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new DragonbornWaffleFries(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new FriedMiraak().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new FriedMiraak(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MadOtarGrits().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MadOtarGrits(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new VolkunSalad().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new VolkunSalad(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new VolkunSalad(Size.Large).ToString());
                });
        }
        [Fact]
        public void DrinkMenuShouldHaveAllEntrees() {
            IEnumerable<IOrderItem> items = Menu.Drinks();

            Assert.Collection(items,
                item => {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new AretinoAppleJuice(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new CandlehearthCoffee(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MarkarthMilk().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Medium).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new MarkarthMilk(Size.Large).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda().ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Cherry).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Cherry).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Blackberry).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Blackberry).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Blackberry).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Grapefruit).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Grapefruit).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Grapefruit).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Lemon).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Lemon).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Lemon).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Peach).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Peach).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Peach).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Small, SodaFlavor.Watermelon).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Medium, SodaFlavor.Watermelon).ToString());
                },
                item => {
                    Assert.Equal(item.ToString(), new SailorSoda(Size.Large, SodaFlavor.Watermelon).ToString());
                });

        }

        [Theory]
        [InlineData("Philly", "Philly Poacher")]
        [InlineData("Burger", "Briarheart Burger")]
        [InlineData("T-Bone", "Thugs T-Bone")] 
        public void SearchReturnsCorrectList(string search, string expected) {
            IEnumerable<IOrderItem> items = Menu.Search(search);
            List<IOrderItem> itemsList = items.ToList<IOrderItem>();
            Assert.Equal(expected, itemsList.Find(x => x.ToString() == expected).ToString()); 
        }

        [Fact]
        public void FoodTypeShouldReturnCorrectList() {
            string[] foodTypes = new string[1];
            foodTypes[0] = "Entree";
            IEnumerable<IOrderItem> OrderItems = Menu.FilterByFoodType(Menu.FullMenu(), foodTypes);
            foreach(IOrderItem item in OrderItems) {
                Assert.IsAssignableFrom<Entree>(item);
            }
            foodTypes[0] = "Drink";
            OrderItems = Menu.FilterByFoodType(Menu.FullMenu(), foodTypes);
            foreach (IOrderItem item in OrderItems) {
                Assert.IsAssignableFrom<Drink>(item);
            }
            foodTypes[0] = "Side";
            OrderItems = Menu.FilterByFoodType(Menu.FullMenu(), foodTypes);
            foreach (IOrderItem item in OrderItems) {
                Assert.IsAssignableFrom<Side>(item);
            }
        }

        [Fact]
        public void PriceRangeShouldReturnCorrectList() {
            IEnumerable<IOrderItem> OrderItems = Menu.FilterByPrice(Menu.FullMenu(), 0, 5);
            foreach (IOrderItem item in OrderItems) {
                Assert.InRange(item.Price, 0, 5);
            }
        }

        [Fact]
        public void CalorieRangeShouldReturnCorrectList() {
            IEnumerable<IOrderItem> OrderItems = Menu.FilterByPrice(Menu.FullMenu(), 0, 400);
            foreach (IOrderItem item in OrderItems) {
                Assert.InRange((int)item.Calories, 0, 400);
            }
        }
    }
}

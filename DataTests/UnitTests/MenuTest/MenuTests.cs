using Xunit;

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
        [Fact]
        public void DescriptionForItemsShouldBeCorrect() {
            var item = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", item.Description);
            var item2 = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", item2.Description);
            var item3 = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", item3.Description);
            var item4 = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", item4.Description);
            var item5 = new GardenOrcOmlette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", item5.Description);
            var item6 = new PhillyPoacher();
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", item6.Description);
            var item7 = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", item7.Description);
            var item8 = new VolkunSalad();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", item8.Description);
            var item9 = new FriedMiraak();
            Assert.Equal("Perfectly prepared hash brown pancakes.", item9.Description);
            var item10 = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", item10.Description);
            var item11 = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", item11.Description);
            var item12 = new SailorSoda(); 
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item12.Description);
            var item13 = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", item13.Description);
            var item14 = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", item14.Description);
            var item15 = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", item15.Description);
            var item16 = new WarriorWater();
            Assert.Equal("It’s water. Just water.", item16.Description);


        }
    }
}

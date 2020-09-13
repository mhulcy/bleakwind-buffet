using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests {
    public class WarriorWaterTests {
        [Fact]
        public void ShouldNotIncludeIceByDefault() {
            var drink = new WarriorWater();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault() {
            var drink = new WarriorWater();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce() {
            var drink = new WarriorWater();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            var drink = new WarriorWater();
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price) {
            var drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(drink.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal) {
            var drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(drink.Calories, cal);

        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce) {
            var drink = new WarriorWater();
            drink.Ice = includeIce;
            if (!drink.Ice) Assert.Contains("Hold ice", drink.SpecialInstructions);
            else Assert.Empty(drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name) {
            var drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(drink.ToString(), name);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var drink = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var drink = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(drink);
        }
    }
}

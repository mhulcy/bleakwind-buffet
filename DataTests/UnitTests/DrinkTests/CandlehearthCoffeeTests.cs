/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var coffee = new CandlehearthCoffee();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var coffee = new CandlehearthCoffee();
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var coffee = new CandlehearthCoffee();
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var coffee = new CandlehearthCoffee();
            Assert.Equal(coffee.Size, Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var coffee = new CandlehearthCoffee();
            coffee.Ice = true;
            Assert.True(coffee.Ice);
            coffee.Ice = false;
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var coffee = new CandlehearthCoffee();
            coffee.Decaf = true;
            Assert.True(coffee.Decaf);
            coffee.Decaf = false;
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var coffee = new CandlehearthCoffee();
            coffee.RoomForCream = true;
            Assert.True(coffee.RoomForCream);
            coffee.RoomForCream = false;
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var coffee = new CandlehearthCoffee();
            coffee.Size = Size.Small;
            Assert.Equal(coffee.Size, Size.Small);
            coffee.Size = Size.Medium;
            Assert.Equal(coffee.Size, Size.Medium);
            coffee.Size = Size.Large;
            Assert.Equal(coffee.Size, Size.Large);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(price, coffee.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var coffee = new CandlehearthCoffee();
            coffee.Size = size;
            Assert.Equal(cal, coffee.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var coffee = new CandlehearthCoffee();
            coffee.Ice = includeIce;
            coffee.RoomForCream = includeCream;
            if(coffee.Ice) Assert.Contains("Add ice", coffee.SpecialInstructions);
            if(coffee.RoomForCream) Assert.Contains("Save room for cream", coffee.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name) {
            var coffee = new CandlehearthCoffee();
            coffee.Decaf = decaf;
            coffee.Size = size;
            Assert.Equal(name, coffee.ToString());
        }
    }
}

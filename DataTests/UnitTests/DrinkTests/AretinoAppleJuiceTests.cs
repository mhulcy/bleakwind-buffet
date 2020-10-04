/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var juice = new AretinoAppleJuice();
            Assert.False(juice.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var juice = new AretinoAppleJuice();
            Assert.Equal(Size.Small, juice.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var juice = new AretinoAppleJuice();
            juice.Ice = true;
            Assert.True(juice.Ice);
            juice.Ice = false;
            Assert.False(juice.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var juice = new AretinoAppleJuice();
            juice.Size = Size.Small;
            Assert.Equal(Size.Small, juice.Size);
            juice.Size = Size.Medium;
            Assert.Equal(Size.Medium, juice.Size);
            juice.Size = Size.Large;
            Assert.Equal(Size.Large, juice.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(juice.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(juice.Calories, cal);

        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var juice = new AretinoAppleJuice();
            juice.Ice = includeIce;
            if (juice.Ice) Assert.Contains("Add ice", juice.SpecialInstructions);
            else Assert.Empty(juice.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(juice.ToString(), name);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty() {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = true;
            });

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty() {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Size", () => {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Size", () => {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Size", () => {
                drink.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesPriceProperty() {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Price", () => {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Price", () => {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Price", () => {
                drink.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty() {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Calories", () => {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Calories", () => {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Calories", () => {
                drink.Size = Size.Small;
            });
        }
    }
}
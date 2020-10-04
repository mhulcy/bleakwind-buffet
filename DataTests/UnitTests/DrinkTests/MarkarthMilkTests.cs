﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var drink = new MarkarthMilk();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var drink = new MarkarthMilk();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var drink = new MarkarthMilk();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var drink = new MarkarthMilk();
            drink.Size = Size.Small;
            Assert.Equal(drink.Size, Size.Small);
            drink.Size = Size.Medium;
            Assert.Equal(drink.Size, Size.Medium);
            drink.Size = Size.Large;
            Assert.Equal(drink.Size, Size.Large);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var drink = new MarkarthMilk();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var drink = new MarkarthMilk();
            drink.Size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var drink = new MarkarthMilk();
            drink.Ice = includeIce;
            if (drink.Ice) Assert.Contains("Add ice", drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var drink = new MarkarthMilk();
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var drink = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var drink = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty() {
            var drink = new MarkarthMilk();

            Assert.PropertyChanged(drink, "Ice", () => {
                drink.Ice = true;
            });

            Assert.PropertyChanged(drink, "Ice", () => {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty() {
            var drink = new MarkarthMilk();

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
            var drink = new MarkarthMilk();

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
            var drink = new MarkarthMilk();

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
﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var side = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var side = new DragonbornWaffleFries();
            side.Size = Size.Small;
            Assert.Equal(side.Size, Size.Small);
            side.Size = Size.Medium;
            Assert.Equal(side.Size, Size.Medium);
            side.Size = Size.Large;
            Assert.Equal(side.Size, Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var side = new DragonbornWaffleFries();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(side);
        }
    }
}
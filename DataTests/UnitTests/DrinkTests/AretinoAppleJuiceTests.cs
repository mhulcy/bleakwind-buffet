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
            Assert.Equal(juice.Size, Size.Small);
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
            Assert.Equal(juice.Size, Size.Small);
            juice.Size = Size.Medium;
            Assert.Equal(juice.Size, Size.Medium);
            juice.Size = Size.Large;
            Assert.Equal(juice.Size, Size.Large);
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
    }
}
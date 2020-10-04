/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault() {
            var side = new VolkunSalad();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize() {
            var side = new VolkunSalad();
            side.Size = Size.Small;
            Assert.Equal(side.Size, Size.Small);
            side.Size = Size.Medium;
            Assert.Equal(side.Size, Size.Medium);
            side.Size = Size.Large;
            Assert.Equal(side.Size, Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions() {
            var side = new VolkunSalad();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var side = new VolkunSalad();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var side = new VolkunSalad();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var side = new VolkunSalad();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var side = new VolkunSalad();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var side = new VolkunSalad();
            Assert.IsAssignableFrom<Side>(side);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty() {
            var side = new VolkunSalad();

            Assert.PropertyChanged(side, "Size", () => {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Size", () => {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Size", () => {
                side.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesPriceProperty() {
            var side = new VolkunSalad();

            Assert.PropertyChanged(side, "Price", () => {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Price", () => {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Price", () => {
                side.Size = Size.Small;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty() {
            var side = new VolkunSalad();

            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Calories", () => {
                side.Size = Size.Small;
            });
        }
    }
}
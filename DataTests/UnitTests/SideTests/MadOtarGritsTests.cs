/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var side = new MadOtarGrits();
            Assert.Equal(Size.Small, side.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var side = new MadOtarGrits();
            side.Size = Size.Small;
            Assert.Equal(side.Size, Size.Small);
            side.Size = Size.Medium;
            Assert.Equal(side.Size, Size.Medium);
            side.Size = Size.Large;
            Assert.Equal(side.Size, Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var side = new MadOtarGrits();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var side = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var side = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(side);
        }
    }
}
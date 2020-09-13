/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var entree = new PhillyPoacher();
            Assert.True(entree.Sirlion);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var entree = new PhillyPoacher();
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var entree = new PhillyPoacher();
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var entree = new PhillyPoacher();
            entree.Sirlion = false;
            Assert.False(entree.Sirlion);
            entree.Sirlion = true;
            Assert.True(entree.Sirlion);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var entree = new PhillyPoacher();
            entree.Onion = false;
            Assert.False(entree.Onion);
            entree.Onion = true;
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var entree = new PhillyPoacher();
            entree.Roll = false;
            Assert.False(entree.Roll);
            entree.Roll = true;
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new PhillyPoacher();
            Assert.Equal(7.23, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new PhillyPoacher();
            Assert.Equal(784, (int)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var entree = new PhillyPoacher();
            entree.Sirlion = includeSirloin;
            entree.Onion = includeOnion;
            entree.Roll = includeRoll;
            if (!entree.Sirlion) Assert.Contains("Hold sirlion", entree.SpecialInstructions);
            if (!entree.Onion) Assert.Contains("Hold onion", entree.SpecialInstructions);
            if (!entree.Roll) Assert.Contains("Hold roll", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new PhillyPoacher();
            Assert.Equal("Philly Poacher", entree.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var entree = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var entree = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(entree);
        }
    }

}
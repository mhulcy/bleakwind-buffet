/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChangedInterface() {
            var drink = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new ThugsTBone();
            Assert.Equal(6.44, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new ThugsTBone();
            Assert.Equal(982, (int)entree.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var entree = new ThugsTBone();
            Assert.Empty(entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", entree.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var entree = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var entree = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(entree);
        }
    }
}
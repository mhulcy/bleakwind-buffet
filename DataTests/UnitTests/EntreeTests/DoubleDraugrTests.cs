﻿/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault() {
            var entree = new DoubleDraugr();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault() {
            var entree = new DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var entree = new DoubleDraugr();
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var entree = new DoubleDraugr();
            entree.Bun = false;
            Assert.False(entree.Bun);
            entree.Bun = true;
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var entree = new DoubleDraugr();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
            entree.Ketchup = true;
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()           
        {
            var entree = new DoubleDraugr();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
            entree.Mustard = true;
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var entree = new DoubleDraugr();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
            entree.Pickle = true;
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var entree = new DoubleDraugr();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
            entree.Cheese = true;
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var entree = new DoubleDraugr();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
            entree.Tomato = true;
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var entree = new DoubleDraugr();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
            entree.Lettuce = true;
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var entree = new DoubleDraugr();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
            entree.Mayo = true;
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new DoubleDraugr();
            Assert.Equal(7.32, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new DoubleDraugr();
            Assert.Equal(843, (int)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            var entree = new DoubleDraugr();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Tomato = includeTomato;
            entree.Lettuce = includeLettuce;
            entree.Mayo = includeMayo;
            if (!entree.Bun) Assert.Contains("Hold bun", entree.SpecialInstructions);
            if (!entree.Ketchup) Assert.Contains("Hold ketchup", entree.SpecialInstructions);
            if (!entree.Mustard) Assert.Contains("Hold mustard", entree.SpecialInstructions);
            if (!entree.Pickle) Assert.Contains("Hold pickle", entree.SpecialInstructions);
            if (!entree.Cheese) Assert.Contains("Hold cheese", entree.SpecialInstructions);
            if (!entree.Tomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!entree.Lettuce) Assert.Contains("Hold lettuce", entree.SpecialInstructions);
            if (!entree.Mayo) Assert.Contains("Hold mayo", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new DoubleDraugr();
            Assert.Equal("Double Draugr", entree.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var entree = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var entree = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Bun", () => {
                entree.Bun = true;
            });

            Assert.PropertyChanged(entree, "Bun", () => {
                entree.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Ketchup", () => {
                entree.Ketchup = true;
            });

            Assert.PropertyChanged(entree, "Ketchup", () => {
                entree.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Mustard", () => {
                entree.Mustard = true;
            });

            Assert.PropertyChanged(entree, "Mustard", () => {
                entree.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Pickle", () => {
                entree.Pickle = true;
            });

            Assert.PropertyChanged(entree, "Pickle", () => {
                entree.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Cheese", () => {
                entree.Cheese = true;
            });

            Assert.PropertyChanged(entree, "Cheese", () => {
                entree.Cheese = false;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Tomato", () => {
                entree.Tomato = true;
            });

            Assert.PropertyChanged(entree, "Tomato", () => {
                entree.Tomato = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Lettuce", () => {
                entree.Lettuce = true;
            });

            Assert.PropertyChanged(entree, "Lettuce", () => {
                entree.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty() {
            var entree = new DoubleDraugr();

            Assert.PropertyChanged(entree, "Mayo", () => {
                entree.Mayo = true;
            });

            Assert.PropertyChanged(entree, "Mayo", () => {
                entree.Mayo = false;
            });
        }
    }
}
﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Net.Http.Headers;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChangedInterface() {
            var drink = new GardenOrcOmlette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var entree = new GardenOrcOmlette();
            Assert.True(entree.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var entree = new GardenOrcOmlette();
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var entree = new GardenOrcOmlette();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var entree = new GardenOrcOmlette();
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var entree = new GardenOrcOmlette();
            entree.Broccoli = false;
            Assert.False(entree.Broccoli);
            entree.Broccoli = true;
            Assert.True(entree.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var entree = new GardenOrcOmlette();
            entree.Mushrooms = false;
            Assert.False(entree.Mushrooms);
            entree.Mushrooms = true;
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var entree = new GardenOrcOmlette();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
            entree.Tomato = true;
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var entree = new GardenOrcOmlette();
            entree.Cheddar = false;
            Assert.False(entree.Cheddar);
            entree.Cheddar = true;
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new GardenOrcOmlette();
            Assert.Equal(4.57, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new GardenOrcOmlette();
            Assert.Equal(404, (int)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var entree = new GardenOrcOmlette();
            entree.Broccoli = includeBroccoli;
            entree.Tomato = includeTomato;
            entree.Cheddar = includeCheddar;
            entree.Mushrooms = includeMushrooms;
            if (!entree.Tomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!entree.Broccoli) Assert.Contains("Hold broccoli", entree.SpecialInstructions);
            if (!entree.Cheddar) Assert.Contains("Hold cheddar", entree.SpecialInstructions);
            if (!entree.Mushrooms) Assert.Contains("Hold mushrooms", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new GardenOrcOmlette();
            Assert.Equal("Garden Orc Omlette", entree.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var entree = new GardenOrcOmlette();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var entree = new GardenOrcOmlette();
            Assert.IsAssignableFrom<Entree>(entree);
        }
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty() {
            var entree = new GardenOrcOmlette();

            Assert.PropertyChanged(entree, "Broccoli", () => {
                entree.Broccoli = true;
            });

            Assert.PropertyChanged(entree, "Broccoli", () => {
                entree.Broccoli = false;
            });
        }
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty() {
            var entree = new GardenOrcOmlette();
            Assert.PropertyChanged(entree, "Mushrooms", () => {
                entree.Mushrooms = true;
            });

            Assert.PropertyChanged(entree, "Mushrooms", () => {
                entree.Mushrooms = false;
            });
        }
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty() {
            var entree = new GardenOrcOmlette();

            Assert.PropertyChanged(entree, "Cheddar", () => {
                entree.Cheddar = true;
            });

            Assert.PropertyChanged(entree, "Cheddar", () => {
                entree.Cheddar = false;
            });
        }
       
        [Fact]
       
        public void ChangingTomatoNotifiesTomatoProperty() {
            var entree = new GardenOrcOmlette();

            Assert.PropertyChanged(entree, "Tomato", () => {
                entree.Tomato = true;
            });

            Assert.PropertyChanged(entree, "Tomato", () => {
                entree.Tomato = false;
            });
        }
        
        
    }
}
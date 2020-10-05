﻿/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChangedInterface() {
            var drink = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            var entree = new SmokehouseSkeleton();
            Assert.True(entree.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            var entree = new SmokehouseSkeleton();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            var entree = new SmokehouseSkeleton();
            Assert.True(entree.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            var entree = new SmokehouseSkeleton();
            Assert.True(entree.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var entree = new SmokehouseSkeleton();
            entree.SausageLink = false;
            Assert.False(entree.SausageLink);
            entree.SausageLink = true;
            Assert.True(entree.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var entree = new SmokehouseSkeleton();
            entree.Egg = false;
            Assert.False(entree.Egg);
            entree.Egg = true;
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var entree = new SmokehouseSkeleton();
            entree.HashBrowns = false;
            Assert.False(entree.HashBrowns);
            entree.HashBrowns = true;
            Assert.True(entree.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var entree = new SmokehouseSkeleton();
            entree.Pancake = false;
            Assert.False(entree.Pancake);
            entree.Pancake = true;
            Assert.True(entree.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var entree = new SmokehouseSkeleton();
            Assert.Equal(5.62, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var entree = new SmokehouseSkeleton();
            Assert.Equal(602, (int)entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var entree = new SmokehouseSkeleton();
            entree.SausageLink = includeSausage;
            entree.Egg = includeEgg;
            entree.HashBrowns = includeHashbrowns;
            entree.Pancake = includePancake;
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var entree = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", entree.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass() {
            var entree = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void CanBeCastToBaseClass() {
            var entree = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(entree);
        }
        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty() {
            var entree = new SmokehouseSkeleton();

            Assert.PropertyChanged(entree, "SausageLink", () => {
                entree.SausageLink = true;
            });

            Assert.PropertyChanged(entree, "SausageLink", () => {
                entree.SausageLink = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty() {
            var entree = new SmokehouseSkeleton();

            Assert.PropertyChanged(entree, "Egg", () => {
                entree.Egg = true;
            });

            Assert.PropertyChanged(entree, "Egg", () => {
                entree.Egg = false;
            });
        }
        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownseProperty() {
            var entree = new SmokehouseSkeleton();

            Assert.PropertyChanged(entree, "HashBrowns", () => {
                entree.HashBrowns = true;
            });

            Assert.PropertyChanged(entree, "HashBrowns", () => {
                entree.HashBrowns = false;
            });
        }
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty() {
            var entree = new SmokehouseSkeleton();

            Assert.PropertyChanged(entree, "Pancake", () => {
                entree.Pancake = true;
            });

            Assert.PropertyChanged(entree, "Pancake", () => {
                entree.Pancake = false;
            });
        }
    }
}
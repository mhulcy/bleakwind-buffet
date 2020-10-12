using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Reflection;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.OrderingTests {
    public class ComboTests {

        

        [Fact]
        public void ThePriceIsCorrect() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);
            Assert.Equal(a.Price + d.Price + b.Price - 1, Combo.Price);
        }

        [Fact]
        public void TheCaloriesAreCorrect() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);
            Assert.Equal(a.Calories + d.Calories + b.Calories, Combo.Calories);
        }

        [Fact]
        public void SpecialInstructionsAreCorrect() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);
            List<string> i = new List<string>();
            i.Add(a.ToString());
            i.Add(d.ToString());
            i.Add(b.ToString());
            Assert.Equal(i, Combo.SpecialInstructions);
        }

        [Fact]
        public void ImplementsINotifyPropertyChangedInterface() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Combo);
        }

        [Fact]
        public void AddingDrinkShouldNotifyEverythingCorrectly() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);
            
            Assert.PropertyChanged(Combo, "Drink", () =>{
                Combo.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(Combo, "Price", () => {
                Combo.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(Combo, "Calories", () => {
                Combo.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(Combo, "SpecialInstructions", () => {
                Combo.Drink = new WarriorWater();
            });
        }

        [Fact]
        public void AddingSideShouldNotifyEverythingCorrectly() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);

            Assert.PropertyChanged(Combo, "Side", () => {
                Combo.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(Combo, "Price", () => {
                Combo.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(Combo, "Calories", () => {
                Combo.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(Combo, "SpecialInstructions", () => {
                Combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void AddingEntreeShouldNotifyEverythingCorrectly() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Combo = new Combo(a, d, b);

            Assert.PropertyChanged(Combo, "Entree", () => {
                Combo.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(Combo, "Price", () => {
                Combo.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(Combo, "Calories", () => {
                Combo.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(Combo, "SpecialInstructions", () => {
                Combo.Entree = new BriarheartBurger();
            });
        }
    }
}

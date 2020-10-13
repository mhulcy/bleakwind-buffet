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
    public class OrderTests {

        [Fact]
        public void ImplementsINotifyPropertyChangedInterface() {
            var a = new AretinoAppleJuice();
            var d = new DragonbornWaffleFries();
            var b = new BriarheartBurger();
            var Order = new Combo(a, d, b);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Order);
        }

        [Fact]
        public void ShouldReturnCorrectSubtotal() {

        }

        [Fact]
        public void AddingToOrderShouldTriggerPropertyChanged() {
            var order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Total", () => {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Tax", () => {
                order.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(order, "Calories", () => {
                order.Add(new BriarheartBurger());
            });
        }
        
        [Fact]
        public void RemovingFromOrderShouldTriggerPropertyChanged() {
            var order = new Order();
            var b = new BriarheartBurger();
            order.Add(b);
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Remove(b);
            });
            order.Add(b);
            Assert.PropertyChanged(order, "Total", () => {
                order.Remove(b);
            });
            order.Add(b);
            Assert.PropertyChanged(order, "Tax", () => {
                order.Remove(b);
            });
            order.Add(b);
            Assert.PropertyChanged(order, "Calories", () => {
                order.Remove(b);
            });
        }

        [Fact]
        public void ChangingPriceOfOrderShouldTriggerPropertyChanged() {
            var order = new Order();
            var d = new AretinoAppleJuice();
            order.Add(d);
            Assert.PropertyChanged(order, "Subtotal", () => {
                d.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Total", () => {
                d.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Tax", () => {
                d.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Calories", () => {
               d.Size = Size.Large;
            });
        }
    }
}

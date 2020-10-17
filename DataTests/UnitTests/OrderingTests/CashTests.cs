using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.OrderingTests {
    public class CashTests {

        [Fact]
        public void CorrectAmountDue() {
            double total = 100.00;
            Cash c = new Cash(total);
            Assert.Equal(100, c.AmountDue);
        }

        [Fact]
        public void CorrectChangeOwed() {
            double total = 100.00;
            Cash c = new Cash(total);
            c.c100Dollars++;
            Assert.Equal(0, c.AmountDue);
        }

        [Fact]
        public void ChangingDollarsNotifiesPropertyChanged() {
            double total = 100.00;
            Cash c = new Cash(total);
            Assert.PropertyChanged(c, "c100Dollars", () => {
                c.c100Dollars++;
            });
            Assert.PropertyChanged(c, "c50Dollars", () => {
                c.c50Dollars++;
            });
            Assert.PropertyChanged(c, "c20Dollars", () => {
                c.c20Dollars++;
            });
            Assert.PropertyChanged(c, "c10Dollars", () => {
                c.c10Dollars++;
            });
        }

        [Fact]
        public void ChangingCentsNotifiesPropertyChanged() {
            double total = 100.00;
            Cash c = new Cash(total);
            Assert.PropertyChanged(c, "c100Cents", () => {
                c.c100Cents++;
            });
            Assert.PropertyChanged(c, "c50Cents", () => {
                c.c50Cents++;
            });
            Assert.PropertyChanged(c, "c25Cents", () => {
                c.c25Cents++;
            });
            Assert.PropertyChanged(c, "c10Cents", () => {
                c.c10Cents++;
            });
        }
        [Fact]
        public void FinalizeSaleWorksProperly() {
            CashDrawer.ResetDrawer();
            double total = 100.00;
            Cash c = new Cash(total);
        }

    }
}

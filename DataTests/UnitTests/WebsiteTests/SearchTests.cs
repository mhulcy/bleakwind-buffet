using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.WebsiteTests {
    public class SearchTests {

        [Fact]
        public void SearchReturnsCorrectList() {
            IEnumerable<IOrderItem> items = Menu.Search("Philly");
            Assert.Contains(new PhillyPoacher(), items);
        }


    }
}

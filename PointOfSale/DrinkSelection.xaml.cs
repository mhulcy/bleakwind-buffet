using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : UserControl {
        public DrinkSelection() {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new MenuSelection();
        }

        private void AppleJuiceButton_Click(object sender, RoutedEventArgs e) {
            var drink = new AretinoAppleJuice();
            this.DataContext = drink;
            this.Content = new NonSodaDrink();
        }

        private void MilkButton_Click(object sender, RoutedEventArgs e) {
            this.DataContext = new MarkarthMilk();
            this.Content = new NonSodaDrink(); //come back to this
        }

        private void CoffeeButton_Click(object sender, RoutedEventArgs e) {
            this.DataContext = new CandlehearthCoffee();
            this.Content = new NonSodaDrink();
        }

        private void SodaButton_Click(object sender, RoutedEventArgs e) {
            this.DataContext = new SailorSoda();
            this.Content = new SodaDrink();
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e) {
            this.DataContext = new WarriorWater();
            this.Content = new NonSodaDrink();
        }
    }
}

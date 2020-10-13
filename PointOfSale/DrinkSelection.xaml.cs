using BleakwindBuffet.Data;
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
            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void AppleJuiceButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink();
            var item = new AretinoAppleJuice();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void MilkButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink();
            var item = new MarkarthMilk();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            } //come back to fix ice eventually
        }

        private void CoffeeButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink();
            var item = new CandlehearthCoffee();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void SodaButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SodaDrink();
            var item = new SailorSoda();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink();
            var item = new WarriorWater();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }
    }
}

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

        private Order o;
        public DrinkSelection(Order order) {
            InitializeComponent();
            o = order;

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
            var sizeComponent = new NonSodaDrink(o);
            var item = new AretinoAppleJuice();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
         
        }

        private void MilkButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink(o);
            var item = new MarkarthMilk();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            //come back to fix ice eventually
        }

        private void CoffeeButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new NonSodaDrink(o);
            var item = new CandlehearthCoffee();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            
        }

        private void SodaButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SodaDrink(o);
            var item = new SailorSoda();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new WarriorWaterControl(o);
            var item = new WarriorWater();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            
        }
    }
}

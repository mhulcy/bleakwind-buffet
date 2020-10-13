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
    /// Interaction logic for NonSodaDrink.xaml
    /// </summary>
    public partial class NonSodaDrink : UserControl {
        public NonSodaDrink() {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new DrinkSelection();
            
        }

        private void Small_Click(object sender, RoutedEventArgs e) {
            Drink drink = (Drink)DataContext;
            drink.Size = BleakwindBuffet.Data.Enums.Size.Small;

            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void Medium_Click(object sender, RoutedEventArgs e) {
            Drink drink = (Drink)DataContext;
            drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;

            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void Large_Click(object sender, RoutedEventArgs e) {
            Drink drink = (Drink)DataContext;
            drink.Size = BleakwindBuffet.Data.Enums.Size.Large;

            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void NoIceButton_Checked(object sender, RoutedEventArgs e) {

        }
    }
}

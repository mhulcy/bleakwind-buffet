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
    /// Interaction logic for WarriorWaterControl.xaml
    /// </summary>
    public partial class WarriorWaterControl : UserControl {

        private Order o;
        public WarriorWaterControl(Order order) {
            InitializeComponent();
            o = order;
            DataContext = new WarriorWater();
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

        private void Small_Click(object sender, RoutedEventArgs e) {
            Drink drink = (Drink)DataContext;
            drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
            o.Add((IOrderItem)drink);

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
            o.Add((IOrderItem)drink);

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
            o.Add((IOrderItem)drink);

            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }
    }
}

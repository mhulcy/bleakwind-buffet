using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl {
        public OrderComponent() {
            InitializeComponent();
            
            //IOrderItem b = new BriarheartBurger();

        }

        private void NewOrderButton_Click(object sender, RoutedEventArgs e) {
            DataContext = new Order();
            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e) {
            Order o = (Order)DataContext;
            o.Remove((IOrderItem)orderList.SelectedItem);
        }
    }
}

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            var orderSelect = new MenuSelection();
            AddToOrderComponent.Child = orderSelect;
            var orderList = new OrderComponent();
            OrderListComponent.Child = orderList;
            
            Order order = new Order();
            this.DataContext = order;
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e) {
            Order o = (Order)DataContext;
            PaymentOptions payment = new PaymentOptions(AddToOrderComponent);
            payment.DataContext = o;
            AddToOrderComponent.Child = payment;
        }
    }
}

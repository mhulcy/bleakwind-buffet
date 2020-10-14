using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurgerComponent : UserControl {

        private Order o;
        public BriarheartBurgerComponent(Order order) {
            InitializeComponent();
            o = order;
            DataContext = new BriarheartBurger();
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

        private void DoneButton_Click(object sender, RoutedEventArgs e) {

            o.Add((BriarheartBurger)DataContext);


            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if(parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void NoBun_Checked(object sender, RoutedEventArgs e) {
           
            BriarheartBurger b = (BriarheartBurger)DataContext;
            if ((bool)NoBun.IsChecked) {
                b.Bun = false;
            }
            else
                b.Bun = true;
            DataContext = b;
        }
    }
}

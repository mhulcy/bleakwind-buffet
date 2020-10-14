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
    /// Interaction logic for SodaDrink.xaml
    /// </summary>
    public partial class SodaDrink : UserControl {

        private Order o;
        public SodaDrink(Order order) {
            InitializeComponent();
            o = order;
            DataContext = new SailorSoda();
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

        private void LemonButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            o.Add(soda);
        }

        private void CherryButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            o.Add(soda);
        }

        private void PeachButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            o.Add(soda);
        }

        private void BlackberryButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            o.Add(soda);
        }

        private void WatermelonButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            o.Add(soda);
        }

        private void GrapefruitButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink(o);
            SailorSoda soda = (SailorSoda)DataContext;
            soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            o.Add(soda);
        }
    }
}

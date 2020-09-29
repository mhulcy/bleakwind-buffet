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
        public SodaDrink() {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new DrinkSelection();
        }

        private void LemonButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink();
        }

        private void CherryButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink();
        }

        private void PeachButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink();
        }

        private void BlackberryButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink();
        }

        private void WatermelonButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new NonSodaDrink();
        }

        private void GrapefruitButton_Click(object sender, RoutedEventArgs e) {

        }
    }
}

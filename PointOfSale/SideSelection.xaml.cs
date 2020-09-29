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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : UserControl {
        public SideSelection() {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new MenuSelection();
        }

        private void FriesButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new SideSizeSelection();
        }

        private void GritsButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new SideSizeSelection();
        }

        private void MiraakButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new SideSizeSelection();
        }

        private void SaladButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new SideSizeSelection();
        }
    }
}

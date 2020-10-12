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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : UserControl {
        public EntreeSelection() {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new MenuSelection();
        }

        private void BriarheartButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new BriarheartBurgerComponent();
            this.DataContext = new BriarheartBurgerComponent();
        }

        private void SmokehouseButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new SmokehouseSkeleton();
            this.DataContext = new SmokehouseSkeleton();
        }

        private void DoubleButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new DoubleDraugr();
            this.DataContext = new DoubleDraugr();
        }

        private void TripleButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new ThalmoreTriple();
            this.DataContext = new ThalmoreTriple();
        }

        private void OmletteButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new GardenOrcOmlette();
            this.DataContext = new GardenOrcOmlette();
        }

        private void TboneButton_Click(object sender, RoutedEventArgs e) {
            this.DataContext = new ThugsTBone();
        }

        private void PhillyButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new PhillyPoacher();
            this.DataContext = new PhillyPoacher();
        }
    }
}

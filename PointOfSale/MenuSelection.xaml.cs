﻿using BleakwindBuffet.Data;
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
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl {
        public MenuSelection() {
            InitializeComponent();
        }

        private void Entree_Click(object sender, RoutedEventArgs e) {
            this.Content = new EntreeSelection((Order)DataContext);
        }

        private void Side_Click(object sender, RoutedEventArgs e) {
            this.Content = new SideSelection();
        }

        private void Drink_Click(object sender, RoutedEventArgs e) {
            this.Content = new DrinkSelection((Order)DataContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Content = new ComboComponent();

        }
    }
}

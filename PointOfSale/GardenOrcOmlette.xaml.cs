﻿using BleakwindBuffet.Data;
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
    /// Interaction logic for GardenOrcOmlette.xaml
    /// </summary>
    public partial class GardenOrcOmletteComponent : UserControl {

        private Order o;
        public GardenOrcOmletteComponent(Order order) {
            
            InitializeComponent();
            o = order;
            DataContext = new GardenOrcOmlette();

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

        private void Button_Click(object sender, RoutedEventArgs e) {
            o.Add((GardenOrcOmlette)DataContext);

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

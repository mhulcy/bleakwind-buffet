﻿using System;
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
    public partial class GardenOrcOmlette : UserControl {
        public GardenOrcOmlette() {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            this.Content = new EntreeSelection();
        }
    }
}

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
    /// Interaction logic for SelectionScreen.xaml
    /// </summary>
    public partial class SelectionScreen : UserControl {
        public SelectionScreen() {
            InitializeComponent();
            var menuSelect = new EntreeSelection();
            SelectionComponent.Child = menuSelect;
        }
    }
}

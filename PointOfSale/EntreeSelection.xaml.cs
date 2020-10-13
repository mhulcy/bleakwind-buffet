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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : UserControl {
        public EntreeSelection() {
            InitializeComponent();
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

        private void BriarheartButton_Click(object sender, RoutedEventArgs e) {

            var itemComponent = new BriarheartBurgerComponent();
            var item = new BriarheartBurger();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void SmokehouseButton_Click(object sender, RoutedEventArgs e) {
            var itemComponent = new SmokehouseSkeletonComponent();
            var item = new SmokehouseSkeleton();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void DoubleButton_Click(object sender, RoutedEventArgs e) {
            var itemComponent = new DoubleDraugrComponent();
            var item = new DoubleDraugr();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void TripleButton_Click(object sender, RoutedEventArgs e) {
            var itemComponent = new ThalmoreTripleComponent();
            var item = new ThalmorTriple();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void OmletteButton_Click(object sender, RoutedEventArgs e) {
            var itemComponent = new GardenOrcOmletteComponent();
            var item = new GardenOrcOmlette();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }

        private void TboneButton_Click(object sender, RoutedEventArgs e) {
            var item = new ThugsTBone();
            if (DataContext is Order list) {
                list.Add(item);
            }
            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }

        }

        private void PhillyButton_Click(object sender, RoutedEventArgs e) {
            var itemComponent = new PhillyPoacherComponent();
            var item = new PhillyPoacher();
            itemComponent.DataContext = item;
            this.Content = itemComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }
    }
}

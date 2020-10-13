using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
            DependencyObject parent = this;
            do {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow) && !(parent is null));
            if (parent is MainWindow main) {
                main.AddToOrderComponent.Child = new MenuSelection();
            }
        }

        private void FriesButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SideSizeSelection();
            var item = new DragonbornWaffleFries();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }

            
        }

        private void GritsButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SideSizeSelection();
            var item = new MadOtarGrits();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }

            
        }

        private void MiraakButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SideSizeSelection();
            var item = new FriedMiraak();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }

        }

        private void SaladButton_Click(object sender, RoutedEventArgs e) {
            var sizeComponent = new SideSizeSelection();
            var item = new VolkunSalad();
            sizeComponent.DataContext = item;
            this.Content = sizeComponent;
            if (DataContext is Order list) {
                list.Add(item);
            }
        }
    }
}

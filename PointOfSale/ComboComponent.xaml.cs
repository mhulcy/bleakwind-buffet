
/*
* Author: Mike Hulcy
* Class name: CashPay.xaml.cs
* Purpose: cs file for ComboComponent User Control
*/

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for ComboComponent.xaml
    /// </summary>
    public partial class ComboComponent : UserControl {
        public ComboComponent() {
            InitializeComponent();
        }

        private void EntreeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void CreateComboButton_Click(object sender, RoutedEventArgs e) {
            Entree entree = new BriarheartBurger();
            if((string)EntreeComboBox.SelectedItem.ToString() == "Briarheart Burger") {
                entree = new BriarheartBurger();
            }
            else if (EntreeComboBox.SelectedItem as string == "Double Draugr") {
                entree = new DoubleDraugr();
            }
            else if ((string)EntreeComboBox.SelectedItem.ToString() == "Thalmore Triple") {
                entree = new ThalmorTriple();
            }
            else if ((string)EntreeComboBox.SelectedItem.ToString() == "Garden Orc Omlette") {
                entree = new GardenOrcOmlette();
            }
            else if ((string)EntreeComboBox.SelectedItem.ToString() == "Philly Poacher") {
                entree = new PhillyPoacher();
            }
            else if ((string)EntreeComboBox.SelectedItem.ToString() == "Smokehouse Skeleton") {
                entree = new SmokehouseSkeleton();
            }
            else if ((string)EntreeComboBox.SelectedItem.ToString() == "Thugs T-Bone") {
                entree = new ThugsTBone();
            }
            Drink drink = new AretinoAppleJuice();
            if((string)DrinkComboBox.SelectedItem.ToString() == "Arentino Apple Juice") {
                drink = new AretinoAppleJuice();
            }
            else if ((string)DrinkComboBox.SelectedItem.ToString() == "Candleheart Coffee") {
                drink = new CandlehearthCoffee();
            }
            else if ((string)DrinkComboBox.SelectedItem.ToString() == "Markarth Milk") {
                drink = new MarkarthMilk();
            }
            else if ((string)DrinkComboBox.SelectedItem.ToString() == "Sailor Soda") {
                drink = new SailorSoda();
            }
            else if ((string)DrinkComboBox.SelectedItem.ToString() == "Warrior Water") {
                drink = new WarriorWater();
            }
            Side side = new DragonbornWaffleFries();
            if((string)SideComboBox.SelectedItem.ToString() == "Dragonborn Waffle Fries") {
                side = new DragonbornWaffleFries();
            }
            else if ((string)SideComboBox.SelectedItem.ToString() == "Fried Miraak") {
                side = new FriedMiraak();
            }
            else if ((string)SideComboBox.SelectedItem.ToString() == "Mad Otar Grits") {
                side = new MadOtarGrits();
            }
            else if ((string)SideComboBox.SelectedItem.ToString() == "Volkun Salad") {
                side = new VolkunSalad();
            }
            Combo combo = new Combo(drink, side, entree);
            Order o = (Order)DataContext;
            o.Add(combo);


        }
    }
}

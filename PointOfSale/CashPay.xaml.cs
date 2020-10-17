/*
* Author: Mike Hulcy
* Class name: CashPay.xaml.cs
* Purpose: cs file for CashPay User Control
*/

using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CashPay.xaml
    /// </summary>
    public partial class CashPay : UserControl, INotifyPropertyChanged {

        

        private Border b;

        public event PropertyChangedEventHandler PropertyChanged;

        public CashPay(Border border) {
            InitializeComponent();
            b = border;
        }

        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e) {
            b.Child = new MenuSelection();
        }

        private void Up100d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c100Dollars++;
            
        }

        private void Down100d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if(!(cash.c100Dollars == 0))
                cash.c100Dollars--;
        }

        private void Up50d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c50Dollars++;
        }

        private void Down50d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c50Dollars == 0))
                cash.c50Dollars--;
        }

        private void Up20d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c20Dollars++;
        }

        private void Down20d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c20Dollars == 0))
                cash.c20Dollars--;
        }

        private void Up10d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c10Dollars++;
        }

        private void Down10d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c10Dollars == 0))
                cash.c10Dollars--;
        }

        private void Up5d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c5Dollars++;
        }

        private void Down5d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c5Dollars == 0))
                cash.c5Dollars--;
        }

        private void Up2d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c2Dollars++;
        }

        private void Down2d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c2Dollars == 0))
                cash.c2Dollars--;
        }

        private void Up1d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c1Dollars++;
        }

        private void Down1d_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c1Dollars == 0))
                cash.c1Dollars--;
        }

        private void Up100c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c100Cents++;
        }

        private void Down100c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c100Cents == 0))
                cash.c100Cents--;
        }

        private void Up50c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c50Cents++;
        }

        private void Down50c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c50Cents == 0))
                cash.c50Cents--;
        }

        private void Up25c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c25Cents++;
        }

        private void Down25c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c25Cents == 0))
                cash.c25Cents--;
        }

        private void Up10c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c10Cents++;
        }

        private void Down10c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c10Cents == 0))
                cash.c10Cents--;
        }

        private void Up5c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c5Cents++;
        }

        private void Down5c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c5Cents == 0))
                cash.c5Cents--;
        }

        private void Up1c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            cash.c1Cents++;
        }

        private void Down1c_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            if (!(cash.c1Cents == 0))
                cash.c1Cents--;
        }

        private void FinilizeSaleButton_Click(object sender, RoutedEventArgs e) {
            Cash cash = (Cash)DataContext;
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds = cash.c100Dollars;
            CashDrawer.Fifties = cash.c50Dollars;
            CashDrawer.Twenties = cash.c20Dollars;
            CashDrawer.Tens = cash.c10Dollars;
            CashDrawer.Fives = cash.c5Dollars;
            CashDrawer.Ones = cash.c1Dollars;
            CashDrawer.Nickels = cash.c5Cents;
            CashDrawer.Dimes = cash.c10Cents;
            CashDrawer.Quarters = cash.c25Cents;
            CashDrawer.HalfDollars = cash.c50Cents;
            CashDrawer.Dollars = cash.c100Cents;

            double change = cash.ChangeOwed;

            CashDrawer.Hundreds -= (int)(change / 100);
            change %= 100;
            CashDrawer.Fifties -= (int)(change / 50);
            change %= 50;
            CashDrawer.Twenties -= (int)(change / 20);
            change %= 20;
            CashDrawer.Tens -= (int)(change / 10);
            change %= 10;
            CashDrawer.Fives -= (int)(change / 5);
            change %= 5;
            CashDrawer.Ones -= (int)(change / 1);
            change %= 1;
            CashDrawer.Dollars -= (int)(change / 1);
            change %= 1;
            CashDrawer.HalfDollars -= (int)(change / .50);
            change %= .50;
            CashDrawer.Quarters -= (int)(change / .25);
            change %= .25;
            CashDrawer.Dimes -= (int)(change / .10);
            change %= .10;
            CashDrawer.Nickels -= (int)(change / .05);
            change %= .05;
            CashDrawer.Pennies -= (int)(change / .01);
            change %= .01;

            RecieptPrinter.PrintLine("Change owed: " + cash.ChangeOwed);
            RecieptPrinter.CutTape();

            MessageBox.Show("Payment Accepted");

        }
    }
}

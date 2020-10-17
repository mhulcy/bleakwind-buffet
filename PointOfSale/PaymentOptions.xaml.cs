/*
* Author: Mike Hulcy
* Class name: CashPay.xaml.cs
* Purpose: cs file for PaymentOptions User Control
*/

using System;
using System.Collections.Generic;
using System.Globalization;
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
using BleakwindBuffet.Data;
using RoundRegister;


namespace PointOfSale {
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl {

        

        private Border b;
        public PaymentOptions(Border addToOrderScreen) {
            InitializeComponent();
            b = addToOrderScreen;
        }

        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e) {
            b.Child = new MenuSelection();
            
        }

        private void CashButton_Click(object sender, RoutedEventArgs e) {
            Order o = (Order)DataContext;

           
                RecieptPrinter.PrintLine("Order Number #" + o.Number);
                DateTime currentTime = DateTime.Now;
                RecieptPrinter.PrintLine(currentTime.ToString());
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem i in o) {
                    RecieptPrinter.PrintLine(i.ToString() + " $" + i.Price);
                    if (i.SpecialInstructions.Count > 0) {
                        foreach (string s in i.SpecialInstructions) {
                            sb.Append("-" + s + " ");
                        }
                    }
                    RecieptPrinter.PrintLine(sb.ToString());
                    sb.Clear();
                }
                RecieptPrinter.PrintLine("Subtotal: " + o.Subtotal.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Tax: " + o.Tax.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Total: " + o.Total.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Payment method: Cash");

            Cash c = new Cash(o.Total);
            CashPay cp = new CashPay(b);
            cp.DataContext = c;
            b.Child = cp;
        }

        private void DebitButton_Click(object sender, RoutedEventArgs e) {
            Order o = (Order)DataContext;
            CardTransactionResult t = RoundRegister.CardReader.RunCard(o.Total);
            if(t == CardTransactionResult.Approved) {
                RecieptPrinter.PrintLine("Order Number #" + o.Number);
                DateTime currentTime = DateTime.Now;
                RecieptPrinter.PrintLine(currentTime.ToString());
                StringBuilder sb = new StringBuilder();
                foreach(IOrderItem i in o) {
                    RecieptPrinter.PrintLine(i.ToString() + " $" + i.Price);
                    if(i.SpecialInstructions.Count > 0) {
                        foreach (string s in i.SpecialInstructions) {
                            sb.Append("-" + s + " ");
                        }
                    }
                    RecieptPrinter.PrintLine(sb.ToString());
                    sb.Clear();
                }
                RecieptPrinter.PrintLine("Subtotal: " + o.Subtotal.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Tax: " + o.Tax.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Total: " + o.Total.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Payment method: Debit Card");
                RecieptPrinter.PrintLine("Change owed: $0.00");
                RecieptPrinter.CutTape();
                MessageBox.Show("Payment Accepted");
            }
            else {
                MessageBox.Show("Card Declined");
            }
        }

        private void CreditButton_Click(object sender, RoutedEventArgs e) {
            Order o = (Order)DataContext;
            CardTransactionResult t = RoundRegister.CardReader.RunCard(o.Total);
            if (t == CardTransactionResult.Approved) {
                RecieptPrinter.PrintLine("Order Number #" + o.Number);
                DateTime currentTime = DateTime.Now;
                RecieptPrinter.PrintLine(currentTime.ToString());
                StringBuilder sb = new StringBuilder();
                foreach (IOrderItem i in o) {
                    RecieptPrinter.PrintLine(i.ToString() + " $" + i.Price);
                    if (i.SpecialInstructions.Count > 0) {
                        foreach (string s in i.SpecialInstructions) {
                            sb.Append("-" + s + " ");
                        }
                    }
                    RecieptPrinter.PrintLine(sb.ToString());
                    sb.Clear();
                }
                RecieptPrinter.PrintLine("Subtotal: " + o.Subtotal.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Tax: " + o.Tax.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Total: " + o.Total.ToString("C", CultureInfo.CurrentCulture));
                RecieptPrinter.PrintLine("Payment method: Credit Card");
                RecieptPrinter.PrintLine("Change owed: $0.00");
                RecieptPrinter.CutTape();
                MessageBox.Show("Payment Accepted");
            }
            else {
                MessageBox.Show("Card Declined");
            }
        }
    }
}

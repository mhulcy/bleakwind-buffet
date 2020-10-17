
/*
* Author: Mike Hulcy
* Class name: CashPay.xaml.cs
* Purpose: holds data for the cash register
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace BleakwindBuffet.Data {
    public class Cash : INotifyPropertyChanged{
        
        public event PropertyChangedEventHandler PropertyChanged;

        private double totalCost;

        public Cash(double d) {
            totalCost = d;
        }

        public double TotalCost {
            get {
                return totalCost;
            }
        }

        private double amountDue;
        public double AmountDue {
            get {
                if (TotalCost - AmountPaid > 0) {
                    return TotalCost - AmountPaid;
                }
                else
                    return 0;
            }
            set {
                changeOwed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private double changeOwed;
        public double ChangeOwed {
            get {
                if (AmountPaid - TotalCost > 0) {
                    return AmountPaid - TotalCost;
                }
                else
                    return 0;
            }
            set {
                changeOwed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }


        private double amountPaid;
        public double AmountPaid {
            get {
                return 100 * c100Dollars + 50 * c50Dollars + 20 * c20Dollars + 10 * c10Dollars + 5 * c5Dollars + 2 * c2Dollars + 1 * c1Dollars + 1 * c100Cents + .50 * c50Cents + .25 * c25Cents + .10 * c10Cents + .05 * c5Cents + .01 * c1Cents; 
            }
        }

        private int _c100Dollars;
        
        public int c100Dollars {

            get {
                return _c100Dollars;
            }
            set {
                _c100Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c100Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        
        }

        private int _c50Dollars;
        public int c50Dollars {

            get {
                return _c50Dollars;
            }
            set {
                _c50Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c50Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }

        }
        private int _c20Dollars;
        public int c20Dollars {

            get {
                return _c20Dollars;
            }
            set {
                _c20Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c20Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        private int _c10Dollars;
        public int c10Dollars {

            get {
                return _c10Dollars;
            }
            set {
                _c10Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c10Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        private int _c5Dollars;
        public int c5Dollars {

            get {
                return _c5Dollars;
            }
            set {
                _c5Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c5Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }

        }
        private int _c1Dollars;
        public int c1Dollars {

            get {
                return _c1Dollars;
            }
            set {
                _c1Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c1Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }

        }
        private int _c2Dollars;
        public int c2Dollars {

            get {
                return _c2Dollars;
            }
            set {
                _c2Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c2Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        private int _c100Cents;
        public int c100Cents {

            get {
                return _c100Cents;
            }
            set {
                _c100Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c100Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        private int _c50Cents;
        public int c50Cents {

            get {
                return _c50Cents;
            }
            set {
                _c50Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c50Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        } 
        
        private int _c25Cents;
        public int c25Cents {

            get {
                return _c25Cents;
            }
            set {
                _c25Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c25Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        private int _c10Cents;
        public int c10Cents {

            get {
                return _c10Cents;
            }
            set {
                _c10Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c10Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        } 
        private int _c5Cents;
        public int c5Cents {

            get {
                return _c5Cents;
            }
            set {
                _c5Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c5Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        } 
        private int _c1Cents;
        public int c1Cents {

            get {
                return _c1Cents;
            }
            set {
                _c1Cents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c1Cents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }


    }
}

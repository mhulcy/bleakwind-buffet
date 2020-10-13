using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data {
    public class Order : ObservableCollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged {

        
        public double SalesTaxRate { get; set; }

        private double subtotal;
        public double Subtotal {
            get {
                subtotal = 0;
                foreach(IOrderItem i in this) {
                    subtotal += i.Price;
                }
                return subtotal;
            }
        }

        private double tax;
        public double Tax {
            get {
                tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }

        private double total;
        public double Total {
            get {
                total = Subtotal + Tax;
                return total;
            }
        }
        private uint calories;
        public uint Calories {
            get {
                foreach(IOrderItem i in this) {
                    calories += i.Calories;
                }
                return calories;
            }
        
        } 

        public int Number { get; }

        private static int nextOrderNumber = 1;

        public Order() {
            SalesTaxRate = .12;
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;

        }
        public new void Add(IOrderItem item) {
            base.Add(item);
            CollectionChanged += CollectionChangedListener;
        }
        public new bool Remove(IOrderItem item) {
            base.Remove(item);
            CollectionChanged += CollectionChangedListener;
            return true;
        }
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e) {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            switch (e.Action) {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems) {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems) {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    foreach (IOrderItem item in e.OldItems) {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    foreach (IOrderItem item in e.NewItems) {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supporrted");

            }
        }
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e) {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));


        }


    }
}

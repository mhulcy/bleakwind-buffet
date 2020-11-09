using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data {
    public class Combo : IOrderItem, INotifyPropertyChanged {

        private double price;
        /// <summary>
        /// price of the combo
        /// </summary>
        public double Price {
            get {
                price = Drink.Price + Side.Price + Entree.Price - 1.00;
                return price;
            }
        }
        private uint calories;
        /// <summary>
        /// calories of the combo
        /// </summary>
        public uint Calories {
            get {
                calories = Drink.Calories + Side.Calories + Entree.Calories;
                return calories;
            }
       
        }
 
        /// <summary>
        /// special instructions for the combo
        /// </summary>
        public List<string> SpecialInstructions { get; }

        private Drink drink;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// drink for the combo
        /// </summary>
        public Drink Drink {
            get {
                return drink;
            }
            set {
                if (drink != null) {
                    SpecialInstructions.Remove(drink.ToString());
                    foreach (string s in drink.SpecialInstructions) {
                        SpecialInstructions.Remove("-" + s);
                    }
                }
                drink = value;
                SpecialInstructions.Add(drink.ToString());
                foreach (string s in drink.SpecialInstructions) {
                    SpecialInstructions.Add("-" + s);
                }



                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private Side side;
        /// <summary>
        /// side for the combo
        /// </summary>
        public Side Side {
            get {
                return side;
            }
            set {
                if (side != null) {
                    SpecialInstructions.Remove(side.ToString());
                    foreach (string s in side.SpecialInstructions) {
                        SpecialInstructions.Remove("-" + s);
                    }
                }
                side = value;
                SpecialInstructions.Add(side.ToString());
                foreach (string s in side.SpecialInstructions) {
                    SpecialInstructions.Add("-" + s);
                }
                
               

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        private Entree entree;
        /// <summary>
        /// side for the combo
        /// </summary>
        public Entree Entree {
            get {
                return entree;
            }
            set {
                if (entree != null) {
                    SpecialInstructions.Remove(entree.ToString());
                    foreach (string s in entree.SpecialInstructions) {
                        SpecialInstructions.Remove("-" + s);
                    }
                }
                entree = value;
                SpecialInstructions.Add(entree.ToString());
                foreach (string s in entree.SpecialInstructions) {
                    SpecialInstructions.Add("-" + s);
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public string FoodType { get; }

        public Combo(Drink d, Side s, Entree e) {
            FoodType = "Combo";
            SpecialInstructions = new List<string>();
            Drink = d;
            Side = s;
            Entree = e;
        }

        public override string ToString() {
            return "Combo";
        }

    }
}

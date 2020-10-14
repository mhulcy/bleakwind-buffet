using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of water
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of water
        /// </summary>
        public override uint Calories { get; set; }
        private bool ice;
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of water as Size enum
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Large;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// if the water should have ice
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if (!value)
                    SpecialInstructions.Add("Hold ice");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool lemon;
        /// <summary>
        /// if the water should have a lemon
        /// </summary>
        public bool Lemon {
            get { return lemon; }
            set {
                lemon = value;
                if (value)
                    SpecialInstructions.Add("Add lemon");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>

        public WarriorWater() {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = Size.Small;
            Calories = 117;
            Ice = true;
            Lemon = false;
        }
        /// <summary>
        /// constructor to set size
        /// </summary>
        /// <param name="inpsize">size to be set</param>
        public WarriorWater(Size inpsize) {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = inpsize;
            Calories = 117;
            Ice = true;
            Lemon = false;
        }
        /// <summary>
        /// turns the water to a string
        /// </summary>
        /// <returns>a string for water</returns>
        public override string ToString() {
            return Size + " Warrior Water";
        }
    }
}

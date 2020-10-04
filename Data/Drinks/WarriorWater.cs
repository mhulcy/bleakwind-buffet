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
        public double Price { get; set; }
        /// <summary>
        /// calories of water
        /// </summary>
        public uint Calories { get; set; }
        private bool ice;
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of water as Size enum
        /// </summary>
        public Size Size {
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
            }
        }
        /// <summary>
        /// if the water should have a lemon
        /// </summary>
        public bool Lemon {
            get { return Lemon; }
            set {
                Lemon = value;
                if (value)
                    SpecialInstructions.Add("add lemon");
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
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

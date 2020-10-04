  using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of fries
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of fries
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// size of fries as Size enum
        /// </summary>
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.42;
                    Calories = 77;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 0.76;
                    Calories = 89;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 0.96;
                    Calories = 100;
                    size = Size.Large;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public DragonbornWaffleFries() {
            SpecialInstructions = new List<String>();
            size = Size.Small;
        }
        /// <summary>
        /// contructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public DragonbornWaffleFries(Size inpsize) {
            SpecialInstructions = new List<String>();
            size = inpsize;
        }
        /// <summary>
        /// turns fries to a string
        /// </summary>
        /// <returns>fries as a string</returns>
        public override string ToString() {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}

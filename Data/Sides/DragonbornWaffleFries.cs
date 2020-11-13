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
        public override double Price { get; set; }
        /// <summary>
        /// calories of fries
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// size of fries as Size enum
        /// </summary>
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        public override Size Size {
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
        public override List<String> SpecialInstructions { get; }

        public string FoodType { get; }
        public override string Description { get; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public DragonbornWaffleFries() {
            Description = "Crispy fried potato waffle fries.";
            FoodType = "Side";
            SpecialInstructions = new List<String>();
            Size = Size.Small;
        }
        /// <summary>
        /// contructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public DragonbornWaffleFries(Size inpsize) {
            Description = "Crispy fried potato waffle fries.";
            FoodType = "Side";
            SpecialInstructions = new List<String>();
            Size = inpsize;
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

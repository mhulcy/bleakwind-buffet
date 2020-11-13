using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged {
        /// <summary 
        /// price of hashbrowns
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of hashbrowns
        /// </summary>
        public override uint Calories { get; set; }
        ///
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of hashbrowns as Size enum
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 1.78;
                    Calories = 151;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 2.01;
                    Calories = 236;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 2.88;
                    Calories = 306;
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
        public FriedMiraak() {
            Description = "Perfectly prepared hash brown pancakes.";
            FoodType = "Side";
            SpecialInstructions = new List<String>();
            Size = Size.Small;

        }
        /// <summary>
        /// contructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public FriedMiraak(Size inpsize) {
            Description = "Perfectly prepared hash brown pancakes.";
            FoodType = "Side";
            SpecialInstructions = new List<String>();
            Size = inpsize;
        }
        /// <summary>
        /// turns hashbrowns to a string
        /// </summary>
        /// <returns>hashbrowns as a string</returns>
        public override string ToString() {
            return Size + " Fried Miraak";
        }
    }
}

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class MarkarthMilk : Drink, IOrderItem {
        /// <summary>
        /// price of milk
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of milk
        /// </summary>
        public uint Calories { get; set; }

        private bool ice;
        private Size size;

        /// <summary>
        /// size of milk as a Size enum
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 1.05;
                    Calories = 56;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.11;
                    Calories = 72;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.22;
                    Calories = 93;
                    size = Size.Large;
                }
            }
        }
        /// <summary>
        /// if the milk should have ice
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if(value)
                    SpecialInstructions.Add("Add ice");
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public MarkarthMilk() {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = Size.Small;
            Calories = 56;
            Ice = false;
        }
        /// <summary>
        /// constructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public MarkarthMilk(Size inpsize) {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = inpsize;
            Calories = 56;
            Ice = false;
        }
        /// <summary>
        /// turns milk to a string
        /// </summary>
        /// <returns>a string for milk</returns>
        public override string ToString() {
            return Size + " Markarth Milk";
        }
    }
}

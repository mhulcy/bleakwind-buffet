using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class VolkunSalad {
        /// <summary>
        /// price of salad
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of salad
        /// </summary>
        public uint Calories { get; set; }
        private Size size;
        /// <summary>
        /// size of salad as Size enum
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.93;
                    Calories = 41;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.23;
                    Calories = 52;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.82;
                    Calories = 73;
                    size = Size.Large;
                }
            }
        }

        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public VolkunSalad() {
            SpecialInstructions = new List<String>();
            size = Size.Small;
            
        }
        /// <summary>
        /// turns salad to a string
        /// </summary>
        /// <returns>salad as a string</returns>
        public override string ToString() {
            return Size + " Vokun Salad";
        }
    }
}

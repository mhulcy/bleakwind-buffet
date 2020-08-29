using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    class VokunSalad {
        private double Price { get; set; }
        private uint Calories { get; set; }
        private Size size;
        private Size Size {
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
       
        private List<String> SpecialInstructions { get; set; }

        public VokunSalad() {
            SpecialInstructions = new List<String>();
            size = Size.Small;
            
        }

        public override string ToString() {
            return Size + " Vokun Salad";
        }
    }
}

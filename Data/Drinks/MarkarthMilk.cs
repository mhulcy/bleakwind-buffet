using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    class MarkarthMilk {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool ice;
        private Size size;
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
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if(value)
                    SpecialInstructions.Add("Add ice");
            }
        }
        public List<String> SpecialInstructions { get; set; }

        public MarkarthMilk() {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = Size.Small;
            Calories = 56;
            Ice = false;
        }

        public override string ToString() {
            return Size + " Martha Milk";
        }
    }
}

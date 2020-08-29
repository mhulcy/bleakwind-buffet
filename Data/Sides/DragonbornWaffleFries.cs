using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    class DragonbornWaffleFries {
        public double Price { get; set; }
        public uint Calories { get; set; }
        private Size size;
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
            }
        }

        public List<String> SpecialInstructions { get; set; }

        public DragonbornWaffleFries() {
            SpecialInstructions = new List<String>();
            size = Size.Small;

        }

        public override string ToString() {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}

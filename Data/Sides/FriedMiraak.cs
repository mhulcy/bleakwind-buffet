using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    class FriedMirak {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private Size size;
        public Size Size {
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
            }
        }

        public List<String> SpecialInstructions { get; set; }

        public FriedMirak() {
            SpecialInstructions = new List<String>();
            size = Size.Small;

        }

        public override string ToString() {
            return Size + " Fried Mirak";
        }
    }
}

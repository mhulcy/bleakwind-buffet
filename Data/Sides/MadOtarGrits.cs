using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    class MadOtarGrits {
        public double Price { get; set; }
        public uint Calories { get; set; }
        private Size size;
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 1.22;
                    Calories = 105;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.58;
                    Calories = 142;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.93;
                    Calories = 179;
                    size = Size.Large;
                }
            }
        }

        public List<String> SpecialInstructions { get; set; }

        public MadOtarGrits() {
            SpecialInstructions = new List<String>();
            size = Size.Small;

        }

        public override string ToString() {
            return Size + " Mad Otar Grits";
        }
    }
}

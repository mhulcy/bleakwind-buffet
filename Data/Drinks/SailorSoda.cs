using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class SailorSoda {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool ice;
        private Size size;
        public SodaFlavor Flavor { get; set; }
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 1.42;
                    Calories = 117;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.74;
                    Calories = 153;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 2.07;
                    Calories = 205;
                    size = Size.Large;
                }
            }
        }
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if(!value)
                    SpecialInstructions.Add("Hold ice");
            }
        }
        public List<String> SpecialInstructions { get; set; }

        public SailorSoda() {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = Size.Small;
            Calories = 117;
            Ice = true;
            Flavor = SodaFlavor.Cherry;
        }
        public override string ToString() {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}

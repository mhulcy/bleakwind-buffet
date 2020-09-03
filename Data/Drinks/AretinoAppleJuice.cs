using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class AretinoAppleJuice {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool ice;
        private Size size;
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.63;
                    Calories = 44;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 0.87;
                    Calories = 88;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.01;
                    Calories = 132;
                    size = Size.Large;
                }
            }
        }
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if (value)
                    SpecialInstructions.Add("Add ice");
            }
        }
        public List<String> SpecialInstructions { get; set; }

        public AretinoAppleJuice() {
            SpecialInstructions = new List<String>();
            Price = 0.62;
            size = Size.Small;
            Calories = 44;
            Ice = false;
        }

        public override string ToString() {
            return Size + " Aretino Apple Juice";
        }
    }
}

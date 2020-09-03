using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class CandlehearthCoffee {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool RoomForCream { get; set; }
        public bool Decaf { get; set; }

        private bool ice;
        private Size size;
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.75;
                    Calories = 7;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.25;
                    Calories = 10;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.75;
                    Calories = 20;
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

        public CandlehearthCoffee() {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = Size.Small;
            Calories = 56;
            Ice = false;
            RoomForCream = false;
            Decaf = false;
        }

        public override string ToString() {
            if (Decaf)
                return Size + " Decaf Candlehearth Coffee";
            else
                return Size + " Candlehearth Coffee";
        }
    }
}

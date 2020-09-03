using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class WarriorWater {
        public double Price { get; set; }
        public uint Calories { get; set; }
        private bool ice;
        private Size size;
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 0.00;
                    Calories = 0;
                    size = Size.Large;
                }
            }
        }
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if (!value)
                    SpecialInstructions.Add("Hold ice");
            }
        }
        public bool Lemon {
            get { return Lemon; }
            set {
                Lemon = value;
                if (value)
                    SpecialInstructions.Add("add lemon");
            }
        }
        public List<String> SpecialInstructions { get; set; }

        public WarriorWater() {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = Size.Small;
            Calories = 117;
            Ice = true;
            Lemon = false;
        }
        public override string ToString() {
            return Size + " Warrior Water";
        }
    }
}

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class FriedMiraak {
        /// <summary>
        /// price of hashbrowns
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of hashbrowns
        /// </summary>
        public uint Calories { get; set; }
        ///
        private Size size;
        /// <summary>
        /// size of hashbrowns as Size enum
        /// </summary>
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

        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public FriedMiraak() {
            SpecialInstructions = new List<String>();
            size = Size.Small;

        }
        /// <summary>
        /// turns hashbrowns to a string
        /// </summary>
        /// <returns>hashbrowns as a string</returns>
        public override string ToString() {
            return Size + " Fried Miraak";
        }
    }
}

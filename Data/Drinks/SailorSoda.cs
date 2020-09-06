﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class SailorSoda {
        /// <summary>
        /// price of soda
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of soda
        /// </summary>
        public uint Calories { get; set; }

        private bool ice;
        private Size size;
        /// <summary>
        /// flavor of soda as SodaFlavor enum
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// size of soda as Size enum
        /// </summary>
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
        /// <summary>
        /// if the soda should have ice
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if(!value)
                    SpecialInstructions.Add("Hold ice");
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public SailorSoda() {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = Size.Small;
            Calories = 117;
            Ice = true;
            Flavor = SodaFlavor.Cherry;
        }
        /// <summary>
        /// turns the soda to a string
        /// </summary>
        /// <returns>a string for soda</returns>
        public override string ToString() {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}

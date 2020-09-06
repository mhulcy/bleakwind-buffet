﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class DragonbornWaffleFries {
        /// <summary>
        /// price of fries
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of fries
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// size of fries as Size enum
        /// </summary>
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
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public DragonbornWaffleFries() {
            SpecialInstructions = new List<String>();
            size = Size.Small;

        }
        /// <summary>
        /// turns fries to a string
        /// </summary>
        /// <returns>fries as a string</returns>
        public override string ToString() {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class MadOtarGrits : Side, IOrderItem {
        /// <summary>
        /// price of grits
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of grits
        /// </summary>
        public uint Calories { get; set; }
        private Size size;
        /// <summary>
        /// size of grits as Size enum
        /// </summary>
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

        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public MadOtarGrits() {
            SpecialInstructions = new List<String>();
            size = Size.Small;
        }
        /// <summary>
        /// contructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public MadOtarGrits(Size inpsize) {
            SpecialInstructions = new List<String>();
            size = inpsize;
        }

        /// <summary>
        /// turns grits to a string
        /// </summary>
        /// <returns>grits as a string</returns>
        public override string ToString() {
            return Size + " Mad Otar Grits";
        }
    }
}

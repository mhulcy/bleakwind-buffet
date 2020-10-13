﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides {
    public class VolkunSalad : Side, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of salad
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of salad
        /// </summary>
        public override uint Calories { get; set; }
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of salad as Size enum
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.93;
                    Calories = 41;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.23;
                    Calories = 52;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.82;
                    Calories = 73;
                    size = Size.Large;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public VolkunSalad() {
            SpecialInstructions = new List<String>();
            Size = Size.Small;
            
        }
        /// <summary>
        /// contructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public VolkunSalad(Size inpsize) {
            SpecialInstructions = new List<String>();
            Size = inpsize;
        }
        /// <summary>
        /// turns salad to a string
        /// </summary>
        /// <returns>salad as a string</returns>
        public override string ToString() {
            return Size + " Vokun Salad";
        }
    }
}

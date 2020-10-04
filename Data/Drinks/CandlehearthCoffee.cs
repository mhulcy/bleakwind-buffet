﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged {
        private bool decaf;
        private bool roomForCream;
        /// <summary>
        /// price of coffee
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of coffee
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// if they should leave room for cream
        /// </summary>
        public bool RoomForCream {
            get { return roomForCream; }
            set {
                roomForCream = value;
                if (value)
                    SpecialInstructions.Add("Save room for cream");
            }
        }
        /// <summary>
        /// if the coffee should be decaf
        /// </summary>
        public bool Decaf {
            get { return decaf; }
            set {
                decaf = value;
                if (value)
                    SpecialInstructions.Add("Decaf");
            }
        }

        private bool ice;
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of the coffee as a Size enum
        /// </summary>
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
        /// <summary>
        /// if they should add ice to the coffee
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if (value)
                    SpecialInstructions.Add("Add ice");
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public CandlehearthCoffee() {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = Size.Small;
            Calories = 56;
            Ice = false;
            RoomForCream = false;
            Decaf = false;
        }
        /// <summary>
        /// constructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public CandlehearthCoffee(Size inpsize) {
            SpecialInstructions = new List<String>();
            Price = 1.05;
            size = inpsize;
            Calories = 56;
            Ice = false;
            RoomForCream = false;
            Decaf = false;
        }
        /// <summary>
        /// turns the coffee into a string
        /// </summary>
        /// <returns>a string for coffee</returns>
        public override string ToString() {
            if (Decaf)
                return Size + " Decaf Candlehearth Coffee";
            else
                return Size + " Candlehearth Coffee";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class BriarheartBurger : Entree, IOrderItem {

        /// <summary>
        /// price of a burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of a burger
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special preparation instructions
        /// </summary>
        public List<String> SpecialInstructions {get; set;}

        private bool bun;
        private bool ketchup;
        private bool mustard;
        private bool pickle;
        private bool cheese;

        /// <summary>
        /// if the burger should have a bun
        /// </summary>
        public bool Bun {
            get { return bun; }
            set {
                bun = value;
                if (!value)
                   SpecialInstructions.Add("Hold bun");
            }
        }
        /// <summary>
        /// if the burger should have ketchup
        /// </summary>
        public bool Ketchup {
            get { return ketchup; }
            set {
                ketchup = value;
                if (!value)
                    SpecialInstructions.Add("Hold ketchup");
            }
        }
        /// <summary>
        /// if the burger should have mustard
        /// </summary>
        public bool Mustard {
            get { return mustard; }
            set {
                mustard = value;
                if (!value)
                    SpecialInstructions.Add("Hold mustard");
            }
        }
        /// <summary>
        /// if the burger should have pickles
        /// </summary>
        public bool Pickle {
            get { return pickle; }
            set {
                pickle = value;
                if (!value)
                    SpecialInstructions.Add("Hold pickle");
            }
        }
        /// <summary>
        /// if the burger should have cheese
        /// </summary>
        public bool Cheese {
            get { return cheese; }
            set {
                cheese = value;
                if (!value)
                    SpecialInstructions.Add("Hold cheese");
            }
        }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public BriarheartBurger() {
            Price = 6.32;
            Calories = 743;
            Bun = true;
            Ketchup = true;
            Mustard = true;
            Pickle = true;
            Cheese = true;

            SpecialInstructions = new List<string>();
        }
        /// <summary>
        /// turns the burger to a string
        /// </summary>
        /// <returns>string for a burger</returns>
        public override String ToString() {
            return "Briarheart Burger";
        }

    }

    
}

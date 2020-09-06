using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class DoubleDraugr {
        /// <summary>
        /// price of a double burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of a double burger
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        private bool bun;
        private bool ketchup;
        private bool mustard;
        private bool pickle;
        private bool cheese;
        private bool tomato;
        private bool lettuce;
        private bool mayo;
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
        /// if the burger should have tomato
        /// </summary>
        public bool Tomato {
            get { return tomato; }
            set {
                tomato = value;
                if (!value)
                    SpecialInstructions.Add("Hold tomato");
            }
        }
        /// <summary>
        /// if the burger should have lettuce
        /// </summary>
        public bool Lettuce {
            get { return lettuce; }
            set {
                lettuce = value;
                if (!value)
                    SpecialInstructions.Add("Hold lettuce");
            }
        }
        /// <summary>
        /// if the burger should have mayo
        /// </summary>
        public bool Mayo {
            get { return mayo; }
            set {
                mayo = value;
                if (!value)
                    SpecialInstructions.Add("Hold mayo");
            }
        }
      
        /// <summary>
        /// Constructor for doubleDraugr
        /// Sets up the defualt values
        /// </summary>
        public DoubleDraugr() {
            SpecialInstructions = new List<String>();
            Price = 7.32;
            Calories = 843;
            Bun = true;
            Ketchup = true;
            Mustard = true;
            Pickle = true;
            Cheese = true;
            Tomato = true;
            Lettuce = true;
            Mayo = true;
        }
        /// <summary>
        /// turns the burger to a string
        /// </summary>
        /// <returns>burger as a string</returns>
        public override String ToString() {
            return "Double Draugr";
        }

    }


}

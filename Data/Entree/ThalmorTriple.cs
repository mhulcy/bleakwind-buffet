using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class ThalmorTriple : Entree, IOrderItem {
        /// <summary>
        /// price of triple burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of triple burger
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
        private bool bacon;
        private bool egg;
        /// <summary>
        /// if the triple burger should have a bun
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
        /// if the triple burger should have ketchup
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
        /// if the triple burger should have mustard
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
        /// if the triple burger should have pickle
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
        /// if the triple burger should have cheese
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
        /// if the triple burger should have tomato
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
        /// if the triple burger should have lettuce
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
        /// if the triple burger should have mayo
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
        /// if the triple burger should have bacon
        /// </summary>
        public bool Bacon {
            get { return bacon; }
            set {
                bacon = value;
                if (!value)
                    SpecialInstructions.Add("Hold bacon");
            }
        }
        /// <summary>
        /// if the triple burger should have egg
        /// </summary>
        public bool Egg {
            get { return egg; }
            set {
                egg = value;
                if (!value)
                    SpecialInstructions.Add("Hold egg");
            }
        }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public ThalmorTriple() {
            SpecialInstructions = new List<String>();
            Price = 8.32;
            Calories = 943;
            Bun = true;
            Ketchup = true;
            Mustard = true;
            Pickle = true;
            Cheese = true;
            Tomato = true;
            Lettuce = true;
            Mayo = true;
            Bacon = true;
            Egg = true;
        }
        /// <summary>
        /// turns triplke burger to a string
        /// </summary>
        /// <returns>triple burger as a string</returns>
        public override String ToString() {
            return "Thalmor Triple";
        }


    }


}

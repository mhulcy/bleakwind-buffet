using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    class ThalmoreTriple {
        public double Price { get; set; }
        public uint Calories { get; set; }
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
        public bool Bun {
            get { return bun; }
            set {
                bun = value;
                if (!value)
                    SpecialInstructions.Add("Hold bun");
            }
        }
        public bool Ketchup {
            get { return ketchup; }
            set {
                ketchup = value;
                if (!value)
                    SpecialInstructions.Add("Hold ketchup");
            }
        }
        public bool Mustard {
            get { return mustard; }
            set {
                mustard = value;
                if (!value)
                    SpecialInstructions.Add("Hold mustard");
            }
        }
        public bool Pickle {
            get { return pickle; }
            set {
                pickle = value;
                if (!value)
                    SpecialInstructions.Add("Hold pickle");
            }
        }
        public bool Cheese {
            get { return cheese; }
            set {
                cheese = value;
                if (!value)
                    SpecialInstructions.Add("Hold cheese");
            }
        }
        public bool Tomato {
            get { return tomato; }
            set {
                tomato = value;
                if (!value)
                    SpecialInstructions.Add("Hold tomato");
            }
        }
        public bool Lettuce {
            get { return lettuce; }
            set {
                lettuce = value;
                if (!value)
                    SpecialInstructions.Add("Hold lettuce");
            }
        }
        public bool Mayo {
            get { return mayo; }
            set {
                mayo = value;
                if (!value)
                    SpecialInstructions.Add("Hold mayo");
            }
        }
        public bool Bacon {
            get { return bacon; }
            set {
                bacon = value;
                if (!value)
                    SpecialInstructions.Add("Hold bacon");
            }
        }
        public bool Egg {
            get { return egg; }
            set {
                egg = value;
                if (!value)
                    SpecialInstructions.Add("Hold egg");
            }
        }
        public ThalmoreTriple() {
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

        public override String ToString() {
            return "Thalmore Triple";
        }


    }


}

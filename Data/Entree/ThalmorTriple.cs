using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of triple burger
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of triple burger
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// if the triple burger should have a bun
        /// </summary>
        public bool Bun {
            get { return bun; }
            set {
                bun = value;
                if (!value)
                    SpecialInstructions.Add("Hold bun");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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

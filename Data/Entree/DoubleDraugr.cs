using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of a double burger
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of a double burger
        /// </summary>
        public override  uint Calories { get; set; }
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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// if the burger should have a bun
        /// </summary>
        public bool Bun {
            get { return bun; }
            set {
                bun = value;
                if (!value)
                    SpecialInstructions.Add("Hold bun");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public string FoodType { get; }
        
        /// <summary>
        /// Constructor for doubleDraugr
        /// Sets up the defualt values
        /// </summary>
        public DoubleDraugr() {
            FoodType = "Entree";
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

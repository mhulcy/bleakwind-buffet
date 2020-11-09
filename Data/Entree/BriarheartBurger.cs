using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// price of a burger
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of a burger
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// list of special preparation instructions
        /// </summary>
        public override List<String> SpecialInstructions {get; }

        private bool bun;
        private bool ketchup;
        private bool mustard;
        private bool pickle;
        private bool cheese;

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
        public string FoodType { get; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public BriarheartBurger() {
            FoodType = "Entree";
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

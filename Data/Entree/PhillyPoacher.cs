using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of the philly
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// calories of the philly
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        private bool sirlion;
        private bool onion;
        private bool roll;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// if the philly should have sirlion
        /// </summary>
        public bool Sirlion {
            get { return sirlion; }
            set {
                sirlion = value;
                if (!value)
                    SpecialInstructions.Add("Hold sirlion");
            }
        }
        /// <summary>
        /// if the philly should have onion
        /// </summary>
        public bool Onion {
            get { return onion; }
            set {
                onion = value;
                if (!value)
                    SpecialInstructions.Add("Hold onion");
            }
        }
        /// <summary>
        /// if the philly should have a roll
        /// </summary>
        public bool Roll {
            get { return roll; }
            set {
                roll = value;
                if (!value)
                    SpecialInstructions.Add("Hold roll");
            }
        }
      
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public PhillyPoacher() {
            SpecialInstructions = new List<String>();
            Price = 7.23;
            Calories = 784;
            Sirlion = true;
            Onion = true;
            Roll = true;
        }
        /// <summary>
        /// turns philly to a string
        /// </summary>
        /// <returns>philly as a string</returns>
        public override String ToString() {
            return "Philly Poacher";
        }

    }


}

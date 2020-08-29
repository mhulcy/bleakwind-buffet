using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    class PhillyPoacher {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }

        private bool sirlion;
        private bool onion;
        private bool roll;
        public bool Sirlion {
            get { return sirlion; }
            set {
                sirlion = value;
                if (!value)
                    SpecialInstructions.Add("Hold sirlion");
            }
        }
        public bool Onion {
            get { return onion; }
            set {
                onion = value;
                if (!value)
                    SpecialInstructions.Add("Hold onion");
            }
        }
        public bool Roll {
            get { return roll; }
            set {
                roll = value;
                if (!value)
                    SpecialInstructions.Add("Hold roll");
            }
        }
      

        public PhillyPoacher() {
            SpecialInstructions = new List<String>();
            Price = 7.23;
            Calories = 784;
            Sirlion = true;
            Onion = true;
            Roll = true;
        }

        public override String ToString() {
            return "Philly Poacher";
        }

    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class GardenOrcOmlette {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }

        private bool broccoli;
        private bool mushrooms;
        private bool tomato;
        private bool cheddar;
        
       
        public bool Broccoli {
            get { return broccoli; }
            set {
                broccoli = value;
                if (!value)
                    SpecialInstructions.Add("Hold broccoli");
            }
        }
        public bool Mushrooms {
            get { return mushrooms; }
            set {
                Mushrooms = value;
                if (!value)
                    SpecialInstructions.Add("Hold mushrooms");
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
        public bool Cheddar {
            get { return cheddar; }
            set {
                cheddar = value;
                if (!value)
                    SpecialInstructions.Add("Hold cheddar");
            }
        }

        public GardenOrcOmlette() {
            SpecialInstructions = new List<String>();
            Price = 4.57;
            Calories = 404;
            Cheddar = true;
            Tomato = true;
            Mushrooms = true;
            Broccoli = true;
        }

        public override String ToString() {
            return "Garden Orc Omlette";
        }

    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class GardenOrcOmlette : Entree, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// price of the omlette
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of the omlette
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        private bool broccoli;
        private bool mushrooms;
        private bool tomato;
        private bool cheddar;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// if the omlette should have broccoli
        /// </summary>
        public bool Broccoli {
            get { return broccoli; }
            set {
                broccoli = value;
                if (!value)
                    SpecialInstructions.Add("Hold broccoli");
            }
        }
        /// <summary>
        /// if the omlette should have mushrooms
        /// </summary>
        public bool Mushrooms {
            get { return mushrooms; }
            set {
                mushrooms = value;
                if (!value)
                    SpecialInstructions.Add("Hold mushrooms");
            }
        }
        /// <summary>
        /// if the omlette should have tomato
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
        /// if the omlette should have cheddar cheese
        /// </summary>
        public bool Cheddar {
            get { return cheddar; }
            set {
                cheddar = value;
                if (!value)
                    SpecialInstructions.Add("Hold cheddar");
            }
        }

        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public GardenOrcOmlette() {
            SpecialInstructions = new List<String>();
            Price = 4.57;
            Calories = 404;
            Cheddar = true;
            Tomato = true;
            Mushrooms = true;
            Broccoli = true;
        }

        /// <summary>
        /// turns omlette to a string
        /// </summary>
        /// <returns>omlette as a string</returns>
        public override String ToString() {
            return "Garden Orc Omlette";
        }

    }


}

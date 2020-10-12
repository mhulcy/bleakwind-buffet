using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of soda
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of soda
        /// </summary>
        public override uint Calories { get; set; }

        private bool ice;
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// flavor of soda as SodaFlavor enum
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// size of soda as Size enum
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 1.42;
                    Calories = 117;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 1.74;
                    Calories = 153;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 2.07;
                    Calories = 205;
                    size = Size.Large;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// if the soda should have ice
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if(!value)
                    SpecialInstructions.Add("Hold ice");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }

        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public SailorSoda() {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = Size.Small;
            Calories = 117;
            Ice = true;
            Flavor = SodaFlavor.Cherry;
        }
        /// <summary>
        /// constructor to set size and flavor
        /// </summary>
        /// <param name="inpsize">size</param>
        /// <param name="flavor">flavor</param>
        public SailorSoda(Size inpsize, SodaFlavor flavor) {
            SpecialInstructions = new List<String>();
            Price = 1.42;
            size = inpsize;
            Calories = 117;
            Ice = true;
            Flavor = flavor;
        }
        /// <summary>
        /// turns the soda to a string
        /// </summary>
        /// <returns>a string for soda</returns>
        public override string ToString() {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}

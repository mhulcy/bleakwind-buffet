using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of the apple juice
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of the apple juice
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// list of special instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        private bool ice;
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of the apple juice as a Size enum
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                if (value == Size.Small) {
                    Price = 0.62;
                    Calories = 44;
                    size = Size.Small;
                }
                else if (value == Size.Medium) {
                    Price = 0.87;
                    Calories = 88;
                    size = Size.Medium;
                }
                else if (value == Size.Large) {
                    Price = 1.01;
                    Calories = 132;
                    size = Size.Large;
                }
            }
        }
        /// <summary>
        /// if the apple juice has ice or not
        /// </summary>
        public bool Ice {
            get { return ice; }
            set {
                ice = value;
                if (value)
                    SpecialInstructions.Add("Add ice");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }
        

        /// <summary>
        /// constructor to set defualt values
        /// </summary>
        public AretinoAppleJuice() {
            SpecialInstructions = new List<String>();
            Price = 0.62;
            size = Size.Small;
            Calories = 44;
            Ice = false;
        }
        /// <summary>
        /// constructor to set size
        /// </summary>
        /// <param name="inpsize">input size</param>
        public AretinoAppleJuice(Size inpsize) {
            SpecialInstructions = new List<String>();
            Price = 0.62;
            size = inpsize;
            Calories = 44;
            Ice = false;
        }

        /// <summary>
        /// turns the apple juice into a string
        /// </summary>
        /// <returns>size apple juice</returns>
        public override string ToString() {
            return Size + " Aretino Apple Juice";
        }
    }
}

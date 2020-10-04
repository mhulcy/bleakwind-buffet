using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of TBone
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of TBone
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special prepatation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public ThugsTBone() {
            Price = 6.44;
            Calories = 982;
            SpecialInstructions = new List<String>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// turns TBone to a string
        /// </summary>
        /// <returns>TBone as a string</returns>
        public override String ToString() {
            return "Thugs T-Bone";
        }

    }


}

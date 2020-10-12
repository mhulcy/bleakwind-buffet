using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of TBone
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of TBone
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// list of special prepatation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }

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

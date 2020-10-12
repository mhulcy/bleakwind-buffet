using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public abstract class Drink {
        /// <summary>
        /// Price of the item
        /// </summary>
        public abstract double Price { get; set; }
        /// <summary>
        /// Calories of the item
        /// </summary>
        public abstract uint Calories { get; set; }
        /// <summary>
        /// Special preperation instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Size of drink
        /// </summary>
        public virtual Size Size { get; set; }

    }
}

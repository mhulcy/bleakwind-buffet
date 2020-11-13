using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data {
    public abstract class Side {
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
        /// Size of side
        /// </summary>
        public virtual Size Size { get; set; }
        public abstract string Description { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public abstract class Entree {
        /// <summary>
        /// Price of the item
        /// </summary>
        double Price { get; set; }
        /// <summary>
        /// Calories of the item
        /// </summary>
        uint Calories { get; set; }
        /// <summary>
        /// Special preperation instructions
        /// </summary>
        List<string> SpecialInstructions { get; set; }
    }
}

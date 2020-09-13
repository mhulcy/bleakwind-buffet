using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public abstract class Drink {
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
        /// <summary>
        /// Size of drink
        /// </summary>
        Size Size { get; set; }

    }
}

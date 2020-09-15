using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
    public abstract class Drink {
        /// <summary>
        /// Price of the item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Calories of the item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special preperation instructions
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// Size of drink
        /// </summary>
        Size Size { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data {
    public abstract class Side {
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
        /// Size of side
        /// </summary>
        Size Size { get; set; }
    }
}

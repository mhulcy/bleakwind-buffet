using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class ThugsTBone {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }


        public ThugsTBone() {
            Price = 6.44;
            Calories = 982;
            SpecialInstructions = new List<String>();
        }

        public override String ToString() {
            return "Thugs T-Bone";
        }

    }


}

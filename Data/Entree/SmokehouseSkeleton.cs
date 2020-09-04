using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class SmokehouseSkeleton {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<String> SpecialInstructions { get; set; }

        private bool egg;
        private bool hashBrowns;
        private bool pancake;
        private bool sausageLink;
        public bool SausageLink {
            get { return sausageLink; }
            set {
                sausageLink = value;
                if (!value)
                    SpecialInstructions.Add("Hold sausage link");
            }
        }
        public bool Egg {
            get { return egg; }
            set {
                egg = value;
                if (!value)
                    SpecialInstructions.Add("Hold egg");
            }
        }
        public bool HashBrowns {
            get { return hashBrowns; }
            set {
                hashBrowns = value;
                if (!value)
                    SpecialInstructions.Add("Hold hash browns");
            }
        }
        public bool Pancake {
            get { return pancake; }
            set {
                pancake = value;
                if (!value)
                    SpecialInstructions.Add("Hold pancake");
            }
        }
      
        public SmokehouseSkeleton() {
            SpecialInstructions = new List<String>();
            Price = 5.62;
            Calories = 602;
            SausageLink = true;
            Egg = true;
            HashBrowns = true;
            Pancake = true;
        }

        public override String ToString() {
            return "Smokehouse Skeleton";
        }

    }


}

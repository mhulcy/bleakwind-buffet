using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree {
    public class SmokehouseSkeleton {
        /// <summary>
        /// price of breakfast combo
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// calories of the breakfast combo
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public List<String> SpecialInstructions { get; set; }

        private bool egg;
        private bool hashBrowns;
        private bool pancake;
        private bool sausageLink;
        /// <summary>
        /// if the breakfast combo should have sausage
        /// </summary>
        public bool SausageLink {
            get { return sausageLink; }
            set {
                sausageLink = value;
                if (!value)
                    SpecialInstructions.Add("Hold sausage link");
            }
        }
        /// <summary>
        /// if the breakfast combo should eggs
        /// </summary>
        public bool Egg {
            get { return egg; }
            set {
                egg = value;
                if (!value)
                    SpecialInstructions.Add("Hold egg");
            }
        }
        /// <summary>
        /// if the breakfast combo should have hashbrowns
        /// </summary>
        public bool HashBrowns {
            get { return hashBrowns; }
            set {
                hashBrowns = value;
                if (!value)
                    SpecialInstructions.Add("Hold hash browns");
            }
        }
        /// <summary>
        /// if the breakfast combo should have pancakes
        /// </summary>
        public bool Pancake {
            get { return pancake; }
            set {
                pancake = value;
                if (!value)
                    SpecialInstructions.Add("Hold pancake");
            }
        }
      
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public SmokehouseSkeleton() {
            SpecialInstructions = new List<String>();
            Price = 5.62;
            Calories = 602;
            SausageLink = true;
            Egg = true;
            HashBrowns = true;
            Pancake = true;
        }

        /// <summary>
        /// turns breakfast combo to a string
        /// </summary>
        /// <returns>string for breakfast combo</returns>
        public override String ToString() {
            return "Smokehouse Skeleton";
        }

    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged {
        /// <summary>
        /// price of breakfast combo
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// calories of the breakfast combo
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// list of special preperation instructions
        /// </summary>
        public override List<String> SpecialInstructions { get; }

        private bool egg;
        private bool hashBrowns;
        private bool pancake;
        private bool sausageLink;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// if the breakfast combo should have sausage
        /// </summary>
        public bool SausageLink {
            get { return sausageLink; }
            set {
                sausageLink = value;
                if (!value)
                    SpecialInstructions.Add("Hold sausage link");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }
        public string FoodType { get; }
        /// <summary>
        /// constructor to setup defualt values
        /// </summary>
        public SmokehouseSkeleton() {
            FoodType = "Entree";
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

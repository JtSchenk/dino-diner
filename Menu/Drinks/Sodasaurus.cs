using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        public double Price { get; set; } = 1.5;

        private Size size;
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Medium)
                {
                    Price = 2.00;
                }
            }
        }

        public bool Ice { get; set; } = true;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        public double Price { get; set; } = 1.5;

        private Size size;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                // set the prices for small and large
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }

        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 156;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavor");
            ingredients.Add("Cane Sugar");
        }
        // ingredients are Water, Natural Flavors, Cane Sugar

        public bool Ice { get; set; } = true;
    }
}

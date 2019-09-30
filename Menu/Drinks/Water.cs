using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        private bool lemon { get; set; } = false;

        private Size size;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                // set the prices for small, medium, and large
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                if (size == Size.Medium)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                if (size == Size.Large)
                {
                    Price = 0.10;
                    Calories = 0;
                }
            }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        public void AddLemon()
        {
            lemon = true;
            if (lemon)
            {
                ingredients.Add("Lemon");
            }
        }
    }
}

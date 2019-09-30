using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private bool sweet = false;

        private bool lemon = false;

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
                    Price = 0.99;
                    Calories = 8;
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                }
            }
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

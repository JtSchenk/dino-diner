using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private bool sweet { get; set; } = false;

        private bool lemon { get; set; } = false;

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
                    if (sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;

                    if (sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    if (sweet)
                    {
                        Calories = Calories * 2;
                    }
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

        public void AddCaneSugar()
        {
            sweet = true;
            if (sweet)
            {
                ingredients.Add("Cane Sugar");
            }
        }



        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }
    }
}

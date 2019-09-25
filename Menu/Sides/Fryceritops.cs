﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        protected Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                Size size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            Ingredients.Add("Potatoes");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }
    }
}
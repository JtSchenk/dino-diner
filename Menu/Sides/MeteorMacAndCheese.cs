﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
        }
    }
}

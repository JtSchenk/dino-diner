﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            Ingredients.Add("Potato");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");
        }
    }
}
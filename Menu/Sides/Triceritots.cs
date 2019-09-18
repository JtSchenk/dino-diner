using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public override Size Size
        {
            private Size size;
            /* set {
            //size = value;
            //switch(size)
            // case Size.Small:
             Price = 0.99;
             Calories = 352;
             break;
             case Sze.Medium:
             Price = 1.45;
             Calories = 410;
             break;
             case Size.Large:
             Price = 1.95;
             Calories = 590;
             break;
            */

            //}
        }
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }



    }
}

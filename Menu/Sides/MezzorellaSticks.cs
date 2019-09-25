using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
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
                    size = value;
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 540;
                            break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 610;
                            break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 720;
                            break;
                    }
                }
            }

        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");
        }
    }
}

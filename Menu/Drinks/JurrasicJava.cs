using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool ICE { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

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
                    Price = 0.59;
                    Calories = 2;
                }
                if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            ICE = true;
        }
    }
}

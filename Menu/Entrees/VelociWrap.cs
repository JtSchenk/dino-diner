using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;


        public VelociWrap()
        {
            this.Calories = 356;
            this.Price = 6.86;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }
    }
}

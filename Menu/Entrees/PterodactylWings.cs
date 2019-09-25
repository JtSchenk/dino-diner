using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {

        public PterodactylWings()
        {
            this.Calories = 318;
            this.Price = 7.21;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}

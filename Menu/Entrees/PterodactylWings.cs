using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        public uint Calories { get; set; }

        public double Price { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
            
        }

        public PterodactylWings()
        {
            this.Calories = 318;
            this.Price = 7.21;
        }
    }
}

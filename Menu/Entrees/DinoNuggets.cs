using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        private uint extranugget = 0;
        
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (int i = 0; i <= extranugget; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Calories = 354;
            this.Price = 4.25;
            
        }

        public void AddNugget()
        {
            extranugget++;
            this.Calories = Calories + 59;
            this.Price = Price + 0.25;
        }
    }


}

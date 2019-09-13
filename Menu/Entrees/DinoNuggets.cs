using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint extranugget = 0;
        

        public uint Calories { get; set; }

        public double Price { get; set; }

        public List<string> Ingredients
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
            this.Calories = Calories + extranugget * 59;
            this.Price = Price + extranugget * 0.25;
        }
    }


}

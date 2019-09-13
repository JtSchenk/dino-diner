using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int extranugget = 0;
        

        public uint Calories { get; set; }

        public double Price { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Calories = 612;
            this.Price = 5.15;
        }

        public void AddNugget()
        {

        }
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class DinoNuggets
    {
        private bool extranugget;
        private int nuggets = 6;

        public uint Calories { get; set; }

        public double Price { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Calories = 612;
            this.Price = 5.15;
        }
    }


}

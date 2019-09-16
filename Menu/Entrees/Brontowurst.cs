using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        
        // private field that intiliates the bun to be true. Later has a method that can change it to false.
        private bool wholewheatbun = true;

        // private field that intiliates the peppers to be true. Later has a method that can change it to false.
        private bool peppers = true;

        // private field that intiliates the onions to be true. Later has a method that can change it to false.
        private bool onions = true;

        /// <summary>
        /// This public field gets and sets the Price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// This public field gets and sets the Calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This method adds the string of the item if it's boolean value is set to "true".
        /// IT then returns the full list of ingredients.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholewheatbun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.wholewheatbun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

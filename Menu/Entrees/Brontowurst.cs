using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class Brontowurst
    {
        //private bool brautwurst = true; will always be true, no need for this code

        private bool wholewheatbun = true;
        private bool peppers = true;
        private bool onions = true;


        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholewheatbun) ingredients.Add("Whole-Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldWholeWheatBun()
        {
            this.wholewheatbun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }
    }
}

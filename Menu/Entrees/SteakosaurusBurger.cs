using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
        private bool wholewheatbun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
        }

        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }
                
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    
    public class Brontowurst : Entree , INotifyPropertyChanged, IOrderItem
    {

        // private field that intiliates the bun to be true. Later has a method that can change it to false.
        private bool wholewheatbun = true;

        // private field that intiliates the peppers to be true. Later has a method that can change it to false.
        private bool peppers = true;

        // private field that intiliates the onions to be true. Later has a method that can change it to false.
        private bool onions = true;

        /// <summary>
        /// This method initiliazes the Brontowurst to have the default ingredients, price, and calories
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// Method for removing bun
        /// </summary>
        public void HoldBun()
        {
            wholewheatbun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method for removing peppers.
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            ingredients.Remove("Peppers");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method for removing onions.
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Brontowurst";
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!wholewheatbun)
                {
                    special.Add("Hold Whole Wheat Bun");
                }
                if (!peppers)
                {
                    special.Add("Hold Peppers");
                }
                if (!onions)
                {
                    special.Add("Hold Onions");
                }

                return special.ToArray();
            }
        }
    }
}

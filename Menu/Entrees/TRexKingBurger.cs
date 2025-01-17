﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// This initilaizes the price, calories, and ingredients for the TRexKingBurger.
        /// </summary>
        /// 


        /// <summary>
        /// Sets the bun to be true.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Sets the lettuce to be true.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Sets the tomato to be true.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Sets the onion to be true.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Sets the pickle to be true.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Sets the ketchup to be true.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Sets the mustard to be true.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Sets the mayo to be true.
        /// </summary>
        private bool mayo = true;

        public TRexKingBurger()
        {
            this.Calories = 728;
            this.Price = 8.45;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Onion");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }

        /// <summary>
        /// Method for holding the bun if desired.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Method for holding the lettuce if desired.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Method for holding the tomato if desired.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Method for holding the onion if desired.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Method for holding the pickle if desired.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Method for holding the ketchup if desired.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Method for holding the mustard if desired.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Method for holding the mayo if desired.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            ingredients.Remove("Mayo");
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun)
                {
                    special.Add("Hold Whole Wheat Bun");
                }
                if (!pickle)
                {
                    special.Add("Hold Pickle");
                }
                if (!ketchup)
                {
                    special.Add("Hold Ketchup");
                }
                if (!mustard)
                {
                    special.Add("Hold Mustard");
                }
                if (!lettuce)
                {
                    special.Add("Hold Lettuce");
                }
                if (!mayo)
                {
                    special.Add("Hold Mayo");
                }
                if (!tomato)
                {
                    special.Add("Hold Tomato");
                }
                if (!onion)
                {
                    special.Add("Hold Onion");
                }

                return special.ToArray();
            }
        }
    }
}

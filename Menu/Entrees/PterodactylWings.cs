﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Initiliazes the PterodactlyWings to have a set number of calories, price, and ingredients.
        /// </summary>
        public PterodactylWings()
        {
            this.Calories = 318;
            this.Price = 7.21;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}

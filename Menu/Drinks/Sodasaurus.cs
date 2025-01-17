﻿/*
 * Sodasaurus.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Private backing variable for flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets and sets the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Sets the Price to it's default value of 1.5
        /// </summary>
        public double Price { get; set; } = 1.5;

        /// <summary>
        /// Private backing variable size.
        /// </summary>
        private Size size;

        /// <summary>
        /// This checks and sets the size equal to small, medium, or large and gives them
        /// a Price & Calories value.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                // set the prices for small and large
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                }
            }
        }

        /// <summary>
        /// Initiliazes the Sodasaurus class to have a default Price, Calories, and ingredients.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        public override string ToString()
        {
            return "Sodasaurus";
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
                return special.ToArray();
            }
        }
    }

}
}

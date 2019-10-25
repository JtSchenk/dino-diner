/*
 * Tyrannotea.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// public variable that sets sweet to false.
        /// </summary>
        public bool sweet { get; set; } = false;

        /// <summary>
        /// public variable that sets lemon to false.
        /// </summary>
        public bool lemon { get; set; } = false;

        /// <summary>
        /// public variable that sets Ice to false.
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// private backing variable Size.
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
                    Price = 0.99;
                    Calories = 8;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    if (sweet)
                    {
                        Calories = Calories * 2;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Calories");
                    }
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");

                    if (sweet)
                    {
                        Calories = Calories * 2;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Calories");
                    }
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Special");
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    if (sweet)
                    {
                        Calories = Calories * 2;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Calories");
                    }
                }
            }
        }

        /// <summary>
        /// This method adds a lemon.
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            if (lemon)
            {
                ingredients.Add("Lemon");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// This method adds Cane Sugar.
        /// </summary>
        public void AddCaneSugar()
        {
            sweet = true;
            if (sweet)
            {
                ingredients.Add("Cane Sugar");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// This method has the default ingredients, Price, and Calories.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        public override string ToString()
        {
            return "Tyrannotea";
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
                if (!lemon)
                {
                    special.Remove("Lemon");
                }
                if (!sweet)
                {
                    special.Remove("Cane Sugar");
                }
                return special.ToArray();
            }
        }

    }
}

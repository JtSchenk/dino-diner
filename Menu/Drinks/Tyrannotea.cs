/*
 * Tyrannotea.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
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
                    if (sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;

                    if (sweet)
                    {
                        Calories = Calories * 2;
                    }
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    if (sweet)
                    {
                        Calories = Calories * 2;
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
    }
}

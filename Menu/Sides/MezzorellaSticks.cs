using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Protected variable size inherited from the Size class.
        /// </summary>
        protected Size size;
        /// <summary>
        /// This method gets and returns the size and then sets the cases for if the size is small, medium, or large
        /// and then sets the prices and calories depending on the size.
        /// </summary>
        public override Size Size
            {
                get
                {
                    return size;
                }
                set
                {
                    size = value;
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 540;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 610;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 720;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Special");
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                    }
                }
            }

        /// <summary>
        /// This method initiliazes the price, calories, and ingredients for the MezzorellaSticks.
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");
        }

        public override string ToString()
        {
            return "MezzorellaSticks";
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

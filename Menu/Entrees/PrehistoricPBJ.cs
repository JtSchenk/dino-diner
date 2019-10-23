using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// sets the peanutButter boolean to be true
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Sets the jelly boolean to be true
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Method that initializes the calories, price, and ingredients for the prehistoric PBG.
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// Method that removes the Peanut Butter if desired.
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method that removes the Jelly if desired.
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// A string representing the entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Gets a description of the order item.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string();
                if (!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if (!jelly)
                {
                    special.Add("Hold Jelly");
                }

                return special.ToArray();
            }
        }
    }
}

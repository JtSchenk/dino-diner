﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
        /// <summary>
        /// protected variable that creates a new list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the Price for other classes
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories for other classes
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and returns the ingredients for other classes
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

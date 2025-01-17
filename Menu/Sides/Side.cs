﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    /// <summary>
    /// This public abstract method is a base for a bunch of sub classes.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Creates a new list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and returns the ingredients into the list of ingredients.
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /*
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                Size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Description");
                NotifyPropertyChanged();
            }
        }
        */
    }
}

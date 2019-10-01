/*
 * TyrannoteaTest.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        /// <summary>
        /// Checks to see if default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if default calories is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if default ice is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Checks to see if default lemon is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.lemon);
        }

        /// <summary>
        /// Checks to see if default sweet is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.sweet);
        }

        /// <summary>
        /// Checks to see if price is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if price is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Checks to see if price is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the ice value is false after invoking HoldIce().
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Checks to see if the lemon was added correctly.
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.lemon);
        }

        /// <summary>
        /// Checks to see if the sweet value was set to true.
        /// </summary>
        [Fact]
        public void ShouldSetSweetPropertyToTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            Assert.True(tea.sweet);
        }

        /// <summary>
        /// Checks to see if the calories after setting sweet to true are correct.
        /// </summary>
        [Fact]
        public void ShouldResultInCorrectCaloriesAfterSettingSweetFromTrueToFalse()
        {

        }

        /// <summary>
        /// Checks to see if the ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            //Assert.Collections.Contains
        }
    }
}

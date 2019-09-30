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
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {

        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {

        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {

        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {

        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {

        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {

        }

        [Fact]
        public void ShouldHoldIce()
        {

        }

        [Fact]
        public void ShouldAddLemon()
        {

        }

        [Fact]
        public void ShouldSetSweetPropertyToTrue()
        {

        }

        [Fact]
        public void ShouldResultInCorrectCaloriesAfterSettingSweetFromTrueToFalse()
        {

        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {

        }
    }
}

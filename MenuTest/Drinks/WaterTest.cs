using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water wat = new Water();
            Assert.Equal<double>(0.00, wat.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water wat = new Water();
            Assert.Equal<uint>(0, wat.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {

        }

        [Fact]
        public void ShouldHaveDefaultLemon()
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
        public void ShouldHaveCorrectIngredients()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
           JurrasicJava java = new JurrasicJava();
           Assert.Equal<double>(1.50, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {

        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {

        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {

        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
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
        public void ShouldAddIce()
        {

        }

        [Fact]
        public void ShouldLeaveSpaceForCream()
        {

        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {

        }
    }
}

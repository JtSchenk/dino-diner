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
            Water wat = new Water();
            Assert.Equal<Size>(Size.Small, wat.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water wat = new Water();
            Assert.False(wat.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            wat.Size = Size.Small;
            Assert.Equal<double>(0.00, wat.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0.00, wat.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0.00, wat.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<double>(0, wat.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0, wat.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0, wat.Calories);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            //Assert.False();
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.lemonforwater);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithoutLemon()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            if(wat.lemonforwater == true)
            {
                Assert.Contains<string>("Lemon", wat.Ingredients);
            }
        }
    }
}

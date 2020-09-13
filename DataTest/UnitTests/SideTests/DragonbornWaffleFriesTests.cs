/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using Data;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            Assert.Equal(Size.Small, d.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            d.Size = Size.Medium;
            Assert.Equal(Size.Medium, d.Size);
            d.Size = Size.Large;
            Assert.Equal(Size.Large, d.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            Assert.Empty(d.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            d.Size = size;

            Assert.Equal(price, d.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            d.Size = size;

            Assert.Equal(calories, d.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonBornWaffleFries d = new DragonBornWaffleFries();
            d.Size = size;

            Assert.Equal(name, d.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItems()
        {
            DragonBornWaffleFries a = new DragonBornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(a);
            Assert.IsAssignableFrom<Side>(a);
        }
    }
}
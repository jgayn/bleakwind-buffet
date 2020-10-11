/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;
using Data;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee ss = new CandlehearthCoffee();
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            //ss.Size = Size.Large;
            //Assert.Equal(Size.Large, ss.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;

            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();

            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;

            List<string> list = new List<string>();
            if (includeIce) list.Add("Add ice");
            if (includeCream) list.Add("Add cream");

            Assert.Equal(list, cc.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = decaf;
            cc.Size = size;

            Assert.Equal(name, cc.ToString());

           
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItems()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(a);
            Assert.IsAssignableFrom<Drink>(a);
        }
        
        [Fact]
        public void IcePropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.PropertyChanged(a, "Ice", () => a.Ice = true);
        }

        [Fact]
        public void RoomForCreamPropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.PropertyChanged(a, "RoomForCream", () => a.RoomForCream = true);
        }

        [Fact]
        public void DecafPropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.PropertyChanged(a, "Decaf", () => a.Decaf = true);
        }

        [Fact]
        public void SizePropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.PropertyChanged(a, "Size", () => a.Size = Size.Large);
            Assert.PropertyChanged(a, "Size", () => a.Size = Size.Medium);
            Assert.PropertyChanged(a, "Size", () => a.Size = Size.Small);
        }

        [Fact]
        public void PricePropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = Size.Small;
            Assert.PropertyChanged(a, "Price", () => a.Price = 0.75);
            a.Size = Size.Medium;
            Assert.PropertyChanged(a, "Price", () => a.Price = 1.25);
            a.Size = Size.Large;
            Assert.PropertyChanged(a, "Price", () => a.Price = 1.75);
        }

        [Fact]
        public void CaloriesPropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = Size.Small;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
            a.Size = Size.Medium;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
            a.Size = Size.Large;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
        }

        [Fact]
        public void InstructionsPropertyChanges()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.PropertyChanged(a, "SpecialInstructions", () => a.SpecialInstructions = new List<string>());
        }
    }
}

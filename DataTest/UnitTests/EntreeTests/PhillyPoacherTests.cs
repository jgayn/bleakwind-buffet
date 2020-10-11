/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using Data;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onions);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onions = false;
            Assert.False(pp.Onions);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784f, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();

            pp.Sirloin = includeSirloin;
            pp.Onions = includeOnion;
            pp.Roll = includeRoll;

            List<string> list = new List<string>();
            if (!includeSirloin) list.Add("Hold sirloin");
            if (!includeOnion) list.Add("Hold onions");
            if (!includeRoll) list.Add("Hold roll");

            Assert.Equal(list, pp.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItems()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(a);
            Assert.IsAssignableFrom<Entree>(a);
        }

        [Fact]
        public void SirloinPropertyChanges()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.PropertyChanged(a, "Sirloin", () => a.Sirloin = false);
        }

        [Fact]
        public void OnionsPropertyChanges()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.PropertyChanged(a, "Onions", () => a.Onions = false);
        }

        [Fact]
        public void RollPropertyChanges()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.PropertyChanged(a, "Roll", () => a.Roll = false);
        }
    }
}
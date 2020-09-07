/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aaj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Ice = true;
            Assert.True(aaj.Ice);
            aaj.Ice = false;
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = Size.Large;
            Assert.Equal(Size.Large, aaj.Size);
            aaj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aaj.Size);
            aaj.Size = Size.Small;
            Assert.Equal(Size.Small, aaj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();

            switch (size)
            {
                case Size.Small:
                    aaj.Size = size;
                    Assert.Equal(price, aaj.Price);
                    break;
                case Size.Medium:
                    aaj.Size = size;
                    Assert.Equal(price, aaj.Price);
                    break;
                case Size.Large:
                    aaj.Size = size;
                    Assert.Equal(price, aaj.Price);
                    break;
            }
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();

            switch (size)
            {
                case Size.Small:
                    aaj.Size = size;
                    Assert.Equal(cal, aaj.Calories);
                    break;
                case Size.Medium:
                    aaj.Size = size;
                    Assert.Equal(cal, aaj.Calories);
                    break;
                case Size.Large:
                    aaj.Size = size;
                    Assert.Equal(cal, aaj.Calories);
                    break;
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();

            if (includeIce)
            {
                aaj.Ice = true;
                List<string> testList = new List<string>();
                testList.Add("Add ice");
                Assert.Equal(aaj.SpecialInstructions, testList);
            }
            else
            {
                aaj.Ice = false;
                Assert.Empty(aaj.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();

            aaj.Size = size;
            Assert.Equal(name, aaj.ToString());
        }
    }
}
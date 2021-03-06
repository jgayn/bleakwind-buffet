﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using Data;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;

            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;

            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;

            if(includeIce)
            {
                List<string> tempList = new List<string>();
                tempList.Add("Add ice");
                Assert.Equal(tempList, mm.SpecialInstructions);
            }
            else
            {
                Assert.Empty(mm.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;

            Assert.Equal(name, mm.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItems()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(a);
            Assert.IsAssignableFrom<Drink>(a);
        }

        [Fact]
        public void IcePropertyChanges()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "Ice", () => a.Ice = true);
        }

        [Fact]
        public void SizePropertyChanges()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "Size", () => a.Size = Size.Medium);
        }

        [Fact]
        public void InstructionsPropertyChanges()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "SpecialInstructions", () => a.SpecialInstructions = new List<string>());
        }

        [Fact]
        public void CaloriesPropertyChanges()
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = Size.Small;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
            a.Size = Size.Medium;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
            a.Size = Size.Large;
            Assert.PropertyChanged(a, "Calories", () => a.Calories = 0);
        }

        [Fact]
        public void PricePropertyChanges()
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = Size.Small;
            Assert.PropertyChanged(a, "Price", () => a.Price = 0);
            a.Size = Size.Medium;
            Assert.PropertyChanged(a, "Price", () => a.Price = 0);
            a.Size = Size.Large;
            Assert.PropertyChanged(a, "Price", () => a.Price = 0);
        }
    }
}
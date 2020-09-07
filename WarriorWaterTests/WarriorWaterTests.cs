using System;
using Xunit;
using BleakwindBuffet;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;

namespace WarriorWaterTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void IceIsTrueByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void LemonIsFalseByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void SizeIsSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void SpecialInstructionsEmptyByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Empty(ww.SpecialInstructions);
        }

        [Fact]
        public void PriceIsZeroByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0, ww.Price);
        }

        [Fact]
        public void CaloriesAreZeroByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0f, ww.Calories);
        }

        [Fact]
        public void SpecialInstructionsAreCorrect()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            ww.Lemon = true;

            Assert.NotEmpty(ww.SpecialInstructions);
            Assert.Equal(2, ww.SpecialInstructions.Count);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ToStringAndSizeAreCorrect(Size size)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;

            switch(size)
            {
                case Size.Small:
                    Assert.Equal("Small Warrior Water", ww.ToString());
                    break;
                case Size.Medium:
                    Assert.Equal("Medium Warrior Water", ww.ToString());
                    break;
                case Size.Large:
                    Assert.Equal("Large Warrior Water", ww.ToString());
                    break;
            }
        }

        [Fact]
        public void SetPriceWorks()
        {
            WarriorWater ww = new WarriorWater();
            ww.Price = 1;

            Assert.Equal(1, ww.Price);
        }

        [Fact]
        public void SetCaloriesWorks()
        {
            WarriorWater ww = new WarriorWater();
            ww.Calories = 100;

            Assert.Equal(100f, ww.Calories);
        }

        [Fact]
        public void SetInstructionsWork()
        {
            List<string> list = new List<string>();
            WarriorWater ww = new WarriorWater();
            list.Add("test");
            list.Add("test1");

            ww.SpecialInstructions = list;
            Assert.Equal(list, ww.SpecialInstructions);
        }
    }
}

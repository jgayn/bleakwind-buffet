/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using Data;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943f, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            List<string> list = new List<string>();

            if (!includeBun) list.Add("Hold bun");
            if (!includeKetchup) list.Add("Hold ketchup");
            if (!includeMustard) list.Add("Hold mustard");
            if (!includePickle) list.Add("Hold pickle");
            if (!includeCheese) list.Add("Hold cheese");
            if (!includeTomato) list.Add("Hold tomato");
            if (!includeLettuce) list.Add("Hold lettuce");
            if (!includeMayo) list.Add("Hold mayo");
            if (!includeBacon) list.Add("Hold bacon");
            if (!includeEgg) list.Add("Hold egg");

            Assert.Equal(list, tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItems()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(a);
            Assert.IsAssignableFrom<Entree>(a);
        }

        [Fact]
        public void BunPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Bun", () => a.Bun = false);
        }

        [Fact]
        public void KetchupPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Ketchup", () => a.Ketchup = false);
        }

        [Fact]
        public void MustardPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Mustard", () => a.Mustard = false);
        }

        [Fact]
        public void PicklePropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Pickle", () => a.Pickle = false);
        }

        [Fact]
        public void CheesePropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Cheese", () => a.Cheese = false);
        }

        [Fact]
        public void TomatoPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Tomato", () => a.Tomato = false);
        }

        [Fact]
        public void LettucePropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Lettuce", () => a.Lettuce = false);
        }

        [Fact]
        public void MayoPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Mayo", () => a.Mayo = false);
        }

        [Fact]
        public void BaconPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Bacon", () => a.Bacon = false);
        }

        [Fact]
        public void EggPropertyChanges()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.PropertyChanged(a, "Egg", () => a.Egg = false);
        }
    }
}
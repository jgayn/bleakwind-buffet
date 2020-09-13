using Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.InterfaceTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesListShouldBePopulated()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());

            List<IOrderItem> entrees = (List<IOrderItem>)Menu.Entrees();
            Assert.True(list[0].ToString() == entrees[0].ToString());
            Assert.True(list[1].ToString() == entrees[1].ToString());
            Assert.True(list[2].ToString() == entrees[2].ToString());
            Assert.True(list[3].ToString() == entrees[3].ToString());
            Assert.True(list[4].ToString() == entrees[4].ToString());
            Assert.True(list[5].ToString() == entrees[5].ToString());
            Assert.True(list[6].ToString() == entrees[6].ToString());
        }

        [Fact]
        public void SidesListShouldBePopulated()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            FriedMiraak fm = new FriedMiraak();
            list.Add(fm);
            fm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(fm);
            fm.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(fm);

            DragonBornWaffleFries dw = new DragonBornWaffleFries();
            list.Add(dw);
            dw.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(dw);
            dw.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(dw);

            MadOtarGrits og = new MadOtarGrits();
            list.Add(og);
            og.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(og);
            og.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(og);

            VokunSalad vs = new VokunSalad();
            list.Add(vs);
            vs.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(vs);
            vs.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(vs);

            List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides();

            Assert.True(list[0].ToString() == sides[0].ToString());
            Assert.True(list[1].ToString() == sides[1].ToString());
            Assert.True(list[2].ToString() == sides[2].ToString());
            Assert.True(list[3].ToString() == sides[3].ToString());
            Assert.True(list[4].ToString() == sides[4].ToString());
            Assert.True(list[5].ToString() == sides[5].ToString());
            Assert.True(list[6].ToString() == sides[6].ToString());
            Assert.True(list[7].ToString() == sides[7].ToString());
            Assert.True(list[8].ToString() == sides[8].ToString());
            Assert.True(list[9].ToString() == sides[9].ToString());
            Assert.True(list[10].ToString() == sides[10].ToString());
            Assert.True(list[11].ToString() == sides[11].ToString());
        }

        [Fact]
        public void DrinksListShouldBePopulated()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            AretinoAppleJuice a = new AretinoAppleJuice();
            list.Add(a);
            a.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(a);
            a.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(a);

            CandlehearthCoffee c = new CandlehearthCoffee();
            list.Add(c);
            c.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(c);
            c.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(c);

            MarkarthMilk m = new MarkarthMilk();
            list.Add(m);
            m.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(m);
            m.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(m);

            WarriorWater w = new WarriorWater();
            list.Add(w);
            w.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(w);
            w.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(w);

            SailorSoda s = new SailorSoda();
            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks();

            Assert.True(list[0].ToString() == drinks[0].ToString());
            Assert.True(list[1].ToString() == drinks[1].ToString());
            Assert.True(list[2].ToString() == drinks[2].ToString());
            Assert.True(list[3].ToString() == drinks[3].ToString());
            Assert.True(list[4].ToString() == drinks[4].ToString());
            Assert.True(list[5].ToString() == drinks[5].ToString());
            Assert.True(list[6].ToString() == drinks[6].ToString());
            Assert.True(list[7].ToString() == drinks[7].ToString());
            Assert.True(list[8].ToString() == drinks[8].ToString());
            Assert.True(list[9].ToString() == drinks[9].ToString());
            Assert.True(list[10].ToString() == drinks[10].ToString());
            Assert.True(list[11].ToString() == drinks[11].ToString());
            Assert.True(list[12].ToString() == drinks[12].ToString());
            Assert.True(list[13].ToString() == drinks[13].ToString());
            Assert.True(list[14].ToString() == drinks[14].ToString());
            Assert.True(list[15].ToString() == drinks[15].ToString());
            Assert.True(list[16].ToString() == drinks[16].ToString());
            Assert.True(list[17].ToString() == drinks[17].ToString());
            Assert.True(list[18].ToString() == drinks[18].ToString());
            Assert.True(list[19].ToString() == drinks[19].ToString());
            Assert.True(list[20].ToString() == drinks[20].ToString());
            Assert.True(list[21].ToString() == drinks[21].ToString());
            Assert.True(list[22].ToString() == drinks[22].ToString());
            Assert.True(list[23].ToString() == drinks[23].ToString());
            Assert.True(list[24].ToString() == drinks[24].ToString());
            Assert.True(list[25].ToString() == drinks[25].ToString());
            Assert.True(list[26].ToString() == drinks[26].ToString());
            Assert.True(list[27].ToString() == drinks[27].ToString());
            Assert.True(list[28].ToString() == drinks[28].ToString());
            Assert.True(list[29].ToString() == drinks[29].ToString());
        }

        [Fact]
        public void FullMenuListIsCorrect()
        {
            List<IOrderItem> fullList = (List<IOrderItem>)Menu.FullMenu();

            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            FriedMiraak fm = new FriedMiraak();
            list.Add(fm);
            fm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(fm);
            fm.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(fm);

            DragonBornWaffleFries dw = new DragonBornWaffleFries();
            list.Add(dw);
            dw.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(dw);
            dw.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(dw);

            MadOtarGrits og = new MadOtarGrits();
            list.Add(og);
            og.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(og);
            og.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(og);

            VokunSalad vs = new VokunSalad();
            list.Add(vs);
            vs.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(vs);
            vs.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(vs);

            AretinoAppleJuice a = new AretinoAppleJuice();
            list.Add(a);
            a.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(a);
            a.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(a);

            CandlehearthCoffee c = new CandlehearthCoffee();
            list.Add(c);
            c.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(c);
            c.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(c);

            MarkarthMilk m = new MarkarthMilk();
            list.Add(m);
            m.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(m);
            m.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(m);

            WarriorWater w = new WarriorWater();
            list.Add(w);
            w.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(w);
            w.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(w);

            SailorSoda s = new SailorSoda();
            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            s.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s);
            s.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s);

            Assert.True(list[0].ToString() == fullList[0].ToString());
            Assert.True(list[1].ToString() == fullList[1].ToString());
            Assert.True(list[2].ToString() == fullList[2].ToString());
            Assert.True(list[3].ToString() == fullList[3].ToString());
            Assert.True(list[4].ToString() == fullList[4].ToString());
            Assert.True(list[5].ToString() == fullList[5].ToString());
            Assert.True(list[6].ToString() == fullList[6].ToString());
            Assert.True(list[7].ToString() == fullList[7].ToString());
            Assert.True(list[8].ToString() == fullList[8].ToString());
            Assert.True(list[9].ToString() == fullList[9].ToString());
            Assert.True(list[10].ToString() == fullList[10].ToString());
            Assert.True(list[11].ToString() == fullList[11].ToString());
            Assert.True(list[12].ToString() == fullList[12].ToString());
            Assert.True(list[13].ToString() == fullList[13].ToString());
            Assert.True(list[14].ToString() == fullList[14].ToString());
            Assert.True(list[15].ToString() == fullList[15].ToString());
            Assert.True(list[16].ToString() == fullList[16].ToString());
            Assert.True(list[17].ToString() == fullList[17].ToString());
            Assert.True(list[18].ToString() == fullList[18].ToString());
            Assert.True(list[19].ToString() == fullList[19].ToString());
            Assert.True(list[20].ToString() == fullList[20].ToString());
            Assert.True(list[21].ToString() == fullList[21].ToString());
            Assert.True(list[22].ToString() == fullList[22].ToString());
            Assert.True(list[23].ToString() == fullList[23].ToString());
            Assert.True(list[24].ToString() == fullList[24].ToString());
            Assert.True(list[25].ToString() == fullList[25].ToString());
            Assert.True(list[26].ToString() == fullList[26].ToString());
            Assert.True(list[27].ToString() == fullList[27].ToString());
            Assert.True(list[28].ToString() == fullList[28].ToString());
            Assert.True(list[29].ToString() == fullList[29].ToString());
            Assert.True(list[30].ToString() == fullList[30].ToString());
            Assert.True(list[31].ToString() == fullList[31].ToString());
            Assert.True(list[32].ToString() == fullList[32].ToString());
            Assert.True(list[33].ToString() == fullList[33].ToString());
            Assert.True(list[34].ToString() == fullList[34].ToString());
            Assert.True(list[35].ToString() == fullList[35].ToString());
            Assert.True(list[36].ToString() == fullList[36].ToString());
            Assert.True(list[37].ToString() == fullList[37].ToString());
            Assert.True(list[38].ToString() == fullList[38].ToString());
            Assert.True(list[39].ToString() == fullList[39].ToString());
            Assert.True(list[40].ToString() == fullList[40].ToString());
            Assert.True(list[41].ToString() == fullList[41].ToString());
            Assert.True(list[42].ToString() == fullList[42].ToString());
            Assert.True(list[43].ToString() == fullList[43].ToString());
            Assert.True(list[44].ToString() == fullList[44].ToString());
            Assert.True(list[45].ToString() == fullList[45].ToString());
            Assert.True(list[46].ToString() == fullList[46].ToString());
            Assert.True(list[47].ToString() == fullList[47].ToString());
            Assert.True(list[48].ToString() == fullList[48].ToString());
        }
    }
}

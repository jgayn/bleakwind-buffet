using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Data
{
    /// <summary>
    /// Public static class to implement a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns a IEnumerable containing all available entrees
        /// </summary>
        /// <returns>List containing all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());

            return list;
        }

        /// <summary>
        /// Returns a IEnumerable containing all available sizes of sides
        /// </summary>
        /// <returns>List containing all sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Small;
            list.Add(fm);
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Size.Medium;
            list.Add(fm2);
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Size.Large;
            list.Add(fm3);

            DragonBornWaffleFries dw = new DragonBornWaffleFries();
            list.Add(dw);
            DragonBornWaffleFries dw2 = new DragonBornWaffleFries();
            dw2.Size = Size.Medium;
            list.Add(dw2);
            DragonBornWaffleFries dw3 = new DragonBornWaffleFries();
            dw3.Size = Size.Large;
            list.Add(dw3);

            MadOtarGrits og = new MadOtarGrits();
            list.Add(og);
            MadOtarGrits og2 = new MadOtarGrits();
            og2.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(og2);
            MadOtarGrits og3 = new MadOtarGrits();
            og3.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(og3);

            VokunSalad vs = new VokunSalad();
            list.Add(vs);
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(vs2);
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(vs3);

            return list;
        }

        /// <summary>
        /// Returns a IEnumerable containing all available variations of drinks
        /// </summary>
        /// <returns>List containing all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
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
            SailorSoda s2 = new SailorSoda();
            s2.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            s2.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s2);
            SailorSoda s3 = new SailorSoda();
            s3.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            s3.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s3);

            SailorSoda s4 = new SailorSoda();
            s4.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            s.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s4);
            SailorSoda s5 = new SailorSoda();
            s5.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            s5.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s5);
            SailorSoda s6 = new SailorSoda();
            s6.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            s6.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s6);

            SailorSoda s7 = new SailorSoda();
            s7.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            s7.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s7);
            SailorSoda s8 = new SailorSoda();
            s8.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            s8.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s8);
            SailorSoda s9 = new SailorSoda();
            s9.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            s9.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s9);

            SailorSoda s10 = new SailorSoda();
            s10.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            s10.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s10);
            SailorSoda s11 = new SailorSoda();
            s11.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            s11.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s11);
            SailorSoda s12 = new SailorSoda();
            s12.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            s12.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s12);

            SailorSoda s13 = new SailorSoda();
            s13.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            s13.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s13);
            SailorSoda s14 = new SailorSoda();
            s14.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            s14.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s14);
            SailorSoda s15 = new SailorSoda();
            s15.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            s15.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s15);

            SailorSoda s16 = new SailorSoda();
            s16.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            s16.Size = BleakwindBuffet.Data.Enums.Size.Small;
            list.Add(s16);
            SailorSoda s17 = new SailorSoda();
            s17.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            s17.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            list.Add(s17);
            SailorSoda s18 = new SailorSoda();
            s18.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            s18.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(s18);

            return list;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> allItems = new List<IOrderItem>();

            List<IOrderItem> entrees = (List<IOrderItem>)Entrees();
            List<IOrderItem> drinks = (List<IOrderItem>)Drinks();
            List<IOrderItem> sides = (List<IOrderItem>)Sides();

            allItems = entrees.Concat(sides).Concat(drinks).ToList();

            return allItems;
        }

        public static IEnumerable<SodaFlavor> Flavors()
        {
            List<SodaFlavor> flavors = new List<SodaFlavor>();
            flavors.Add(SodaFlavor.Blackberry);
            flavors.Add(SodaFlavor.Cherry);
            flavors.Add(SodaFlavor.Grapefruit);
            flavors.Add(SodaFlavor.Lemon);
            flavors.Add(SodaFlavor.Peach);
            flavors.Add(SodaFlavor.Watermelon);

            return flavors;
        }
    }
}

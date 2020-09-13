using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}

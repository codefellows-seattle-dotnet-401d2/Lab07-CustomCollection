using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceStore.Classes
{
    public enum Painted
    {
        Red, Orange, Yellow,
        Green, Blue, Indigo,
        Violet, White, Black,
        Gold, Silver, Clearcoat
    }

    class Item
    {
        int ItemID { get; set; }

        int Price { get; set; }

        private Painted _painted;

        public Item(Painted painted)
        {
            _painted = painted;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ECommerceStore.Interfaces;

namespace ECommerceStore.Classes
{
    public class SuperList : System.Collections.Generic.List<String>, iSuper
    {
        public int Size { get = this  }

        public int AtIndexOf(Item item)
        {
            for(int i = 0; i <= this.Size; i++)
            {
                if(item == this.)
            }
        }
    }
}

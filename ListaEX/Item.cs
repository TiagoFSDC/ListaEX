using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEX
{
    internal class Item
    {
        public int Value { get; set; }

        public Item Next { get; set; }

        public Item(int x) 
        {
            Value = x;
            Next = null;
        }

    }
}

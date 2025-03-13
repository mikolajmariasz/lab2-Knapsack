using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]


namespace lab2_Knapsack
{
    class Item
    {
        public int Index;
        public int Value;
        public int Weight;
        public Item(int index, int value, int weight)
        {
            Index = index;
            Value = value;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Value: {Value}, Weight: {Weight}";
        }
    }
}

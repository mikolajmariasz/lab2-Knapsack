using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Knapsack
{
    class Knapsack
    {
        public int Capacity { get; set; }
        public List<Item> Items { get; set; }

        public Knapsack(int capacity, List<Item> items)
        {
            Capacity = capacity;
            Items = items;
        }

        public int SolveKnapsack(List<Item> items)
        {
            int n = items.Count();
            return 0;
        }
    }
}

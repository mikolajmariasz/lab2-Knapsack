using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]

namespace lab2_Knapsack
{
    class Knapsack
    {
        public int Capacity { get; private set; }
        public List<Item> Items { get; private set; }

        public Knapsack(int numberOfItems, int seed, int capacity)
        {
            Random random = new Random(seed);
            Items = new List<Item>();
            for (int i = 0; i < numberOfItems; i++)
            {
                int value = random.Next(10);
                int weight = random.Next(10);
                Items.Add(new Item(i, value, weight));
            }
            Capacity = capacity;
        }

        public Knapsack(List<Item> items, int capacity)
        {
            Capacity = capacity;
            Items = items;
        }

        public void printKnapsackItems()
        {
            foreach (var item in Items)
                Console.WriteLine(item);
        }
    }
}

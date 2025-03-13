using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Knapsack
{
    class Result
    {
        public List<Item> Items { get; private set; }
        public int totalWeight { get; private set; }
        public int totalValue { get; private set; }

        public Result(List<Item> selectedItems)
        {
            Items = selectedItems;
            totalWeight = selectedItems.Sum(i => i.Weight);
            totalValue = selectedItems.Sum(i => i.Value);
        }

        public void printSelectedItems()
        {
            foreach (var item in Items)
                Console.WriteLine(item);
        }
    }
}

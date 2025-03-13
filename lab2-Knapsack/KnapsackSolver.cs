using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]


namespace lab2_Knapsack
{
    internal class KnapsackSolver
    {
        public static List<Item> Solve(Knapsack knapsackInstance)
        {
            List<Item> sortedItems = knapsackInstance.Items.OrderByDescending(x => (double)x.Value / x.Weight).ToList();
            List<Item> selectedItems = new List<Item>();
            int remainingCapacity = knapsackInstance.Capacity;

            foreach (var item in sortedItems)
            {
                if (item.Weight <= remainingCapacity)
                {
                    selectedItems.Add(item);
                    remainingCapacity -= item.Weight;
                }
            }
            return selectedItems;
        }

    }
}

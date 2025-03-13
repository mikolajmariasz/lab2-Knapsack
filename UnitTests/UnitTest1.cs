using lab2_Knapsack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackTests
{
    [TestClass]
    public class KnapsackUnitTests
    {
        [DataTestMethod]
        [DataRow(10, 1, 50)]
        [DataRow(20, 2, 100)]
        [DataRow(5, 3, 20)]
        public void TestKnapsackInstance_GeneratesCorrectNumberOfItems(int itemCount, int seed, int capacity)
        {
            var instance = new Knapsack(itemCount, seed, capacity);
            Assert.AreEqual(itemCount, instance.Items.Count, $"Expected {itemCount} items, but got {instance.Items.Count}.");
        }

        [DataTestMethod]
        [DataRow(10, 1, 50)]
        [DataRow(15, 2, 75)]
        [DataRow(8, 5, 40)]
        public void TestKnapsackSolver_WeightDoesNotExceedCapacity(int itemCount, int seed, int capacity)
        {
            var instance = new Knapsack(itemCount, seed, capacity);
            List<Item> selectedItems = KnapsackSolver.Solve(instance);
            int totalWeight = selectedItems.Sum(i => i.Weight);

            Assert.IsTrue(totalWeight <= instance.Capacity, $"Total weight {totalWeight} is bigger than capacity {capacity}.");
        }

        [DataTestMethod]
        [DataRow(10, 1, 50)]
        [DataRow(20, 3, 100)]
        [DataRow(5, 6, 25)]
        public void TestKnapsackSolver_HasNonEmptySelection(int itemCount, int seed, int capacity)
        {
            var instance = new Knapsack(itemCount, seed, capacity);
            List<Item> selectedItems = KnapsackSolver.Solve(instance);

            Assert.IsTrue(selectedItems.Count > 0, "No items were selected.");
        }

    }
}

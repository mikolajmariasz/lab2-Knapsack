using lab2_Knapsack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackTests
{
    public class KnapsackUnitTests
    {
        [TestClass]
        public class KnapsackSolverTests
        {
            // Sprawdza czy kiedy conajmniej jeden element sie miesci, wynik zwraca conajmniej jeden element
            [TestMethod]
            public void Solve_ShouldReturnAtLeastOneItem_WhenAtLeastOneItemFits()
            {
                List<Item> items = new List<Item>()
                {
                    new Item(1, 10, 7),
                    new Item(2, 12, 8),
                    new Item(3, 15, 12),
                };
                Knapsack knapsack = new Knapsack(items, 10);
                var result = KnapsackSolver.Solve(knapsack);

                Assert.IsTrue(result.Count > 0, "At least one item should be returned when one item fits.");
            }
            // Sprawdza czy kiedy nie ma zadnego elementu, funkcja rozwiazujaca problem nie zwraca zadnego elementu
            [TestMethod]
            public void Solve_ShouldNoItems_WhenNoItemFits()
            {
                List<Item> items = new List<Item>()
                {
                    new Item(1, 10, 11),
                    new Item(2, 12, 12),
                    new Item(3, 15, 13),
                };
                Knapsack knapsack = new Knapsack(items, 10);
                var result = KnapsackSolver.Solve(knapsack);

                Assert.IsTrue(result.Count == 0, "No item should be returned when no item fits.");
            }
            // Sprawdza poprawnosc rozwiazania dla zdefiniowanej instancji problemu
            [TestMethod]
            public void Solve_IsResultCorrect()
            {
                List<Item> items = new List<Item>()
                {
                    new Item(2, 10, 6),
                    new Item(1, 10, 4),
                    new Item(3, 10, 7),
                };

                List<Item> correctResult = new List<Item>()
                {
                    new Item(1, 10, 4),
                    new Item(1, 10, 6),

                };
                Knapsack knapsack = new Knapsack(items, 10);
                var result = KnapsackSolver.Solve(knapsack);

                Assert.AreEqual(correctResult, result, "Result and correct result are not equal.");
            }
            // Sprawdza czy przy tworzeniu instancji problemu generowana jest wlasciwa liczba elementow
            [DataTestMethod]
            [DataRow(10, 1, 50)]
            [DataRow(20, 2, 100)]
            [DataRow(5, 3, 20)]
            public void TestKnapsackInstance_GeneratesCorrectNumberOfItems(int itemCount, int seed, int capacity)
            {
                var instance = new Knapsack(itemCount, seed, capacity);
                Assert.AreEqual(itemCount, instance.Items.Count, $"Expected {itemCount} items, but got {instance.Items.Count}.");
            }
            // Sprawdza czy po rozwiazaniu problemu waga elementow nie przekracza pojemnosci plecaka
            [DataTestMethod]
            [DataRow(10, 1, 50)]
            [DataRow(15, 2, 75)]
            [DataRow(8, 5, 40)]
            public void TestKnapsackSolver_WeightDoesNotExceedCapacity(int itemCount, int seed, int capacity)
            {
                var instance = new Knapsack(itemCount, seed, capacity);
                Result result = new Result(KnapsackSolver.Solve(instance));
      
                Assert.IsTrue(result.totalWeight <= instance.Capacity, $"Total weight {result.totalWeight} is bigger than capacity {capacity}.");
            }
        }
    }
}

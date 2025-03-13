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

        }


    }
}

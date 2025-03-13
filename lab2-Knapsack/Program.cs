using System.Runtime.CompilerServices;

namespace lab2_Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());
            Console.Write("Enter number of items: ");
            int numberOfItems = int.Parse(Console.ReadLine());
            Console.Write("Enter capacity of Knapsack: ");
            int capacity = int.Parse(Console.ReadLine());
            Knapsack instance = new Knapsack(numberOfItems, seed, capacity);

            Console.WriteLine("Generated Items:");
            instance.printKnapsackItems();

            Result result = new Result(KnapsackSolver.Solve(instance));
            Console.WriteLine("\nSelected Items:");
            result.printSelectedItems();
            Console.WriteLine($"Total value: {result.totalValue}");
            Console.WriteLine($"Total weight: {result.totalWeight}");
        }
    }
}

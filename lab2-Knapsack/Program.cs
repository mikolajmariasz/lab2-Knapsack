using System.Runtime.CompilerServices;

namespace lab2_Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());
            Knapsack instance = new Knapsack(10, seed, 10);

            Console.WriteLine("Generated Items:");
            foreach (var item in instance.Items)
                Console.WriteLine(item);

            List<Item> result = KnapsackSolver.Solve(instance);
            Console.WriteLine("\nSelected Items:");
            foreach (var item in result)
                Console.WriteLine(item);
            Console.WriteLine($"Total value: {result.Sum(i => i.Value)}");
            Console.WriteLine($"Total weight: {result.Sum(i => i.Weight)}");
        }
    }
}

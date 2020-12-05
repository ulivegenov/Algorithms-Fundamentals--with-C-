namespace _05.GeneratingCombinations
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split()
                                            .Select(int.Parse)
                                            .ToArray();

            int vectorLength = int.Parse(Console.ReadLine());
            int[] vector = new int[vectorLength];


            GeneratingCombinations(input, vector, 0, 0);
        }

        private static void GeneratingCombinations(int[] set, int[] vector, int vectorIndex, int setIndex)
        {
            if (vectorIndex > vector.Length - 1)
            {
                Console.WriteLine((string.Join(" ", vector)));
                return;
            }

            for (int i = setIndex; i < set.Length; i++)
            {
                vector[vectorIndex] = set[i];
                GeneratingCombinations(set, vector, vectorIndex + 1, i + 1);
            }
        }
    }
}

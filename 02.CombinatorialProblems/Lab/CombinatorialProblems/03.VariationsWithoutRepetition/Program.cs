namespace _03.VariationsWithoutRepetition
{
    using System;

    public class Program
    {
        private static bool[] used;

        public static void Main()
        {
            var elements = Console.ReadLine().Split();
            used = new bool[elements.Length];
            var variationLength = int.Parse(Console.ReadLine());

            var variation = new string[variationLength];

            GetVariations(elements, variation, 0);
        }

        private static void GetVariations(string[] elements, string[] variation, int variationIndex)
        {
            if (variationIndex > variation.Length - 1)
            {
                PrintCombination(variation);
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variation[variationIndex] = elements[i];
                    GetVariations(elements, variation, variationIndex + 1);
                    used[i] = false;
                }
                
            }
        }

        private static void PrintCombination(string[] variation)
        {
            Console.WriteLine(string.Join(" ", variation));
        }
    }
}

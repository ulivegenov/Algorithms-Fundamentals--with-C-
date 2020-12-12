namespace _04.VariationsWithRepetition
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split();
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
                variation[variationIndex] = elements[i];
                GetVariations(elements, variation, variationIndex + 1);
            }
        }

        private static void PrintCombination(string[] variation)
        {
            Console.WriteLine(string.Join(" ", variation));
        }
    }
}

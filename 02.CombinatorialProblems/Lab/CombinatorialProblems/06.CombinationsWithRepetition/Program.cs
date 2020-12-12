namespace _06.CombinationsWithRepetition
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split();
            var combinationLength = int.Parse(Console.ReadLine());

            var combination = new string[combinationLength];

            GetVariations(elements, combination, 0, 0);
        }

        private static void GetVariations(string[] elements, string[] combination, int elemеntIndex, int combinationIndex)
        {
            if (combinationIndex > combination.Length - 1)
            {
                PrintCombination(combination);
                return;
            }

            for (int i = elemеntIndex; i < elements.Length; i++)
            {
                combination[combinationIndex] = elements[i];
                GetVariations(elements, combination, i, combinationIndex + 1);
            }
        }

        private static void PrintCombination(string[] combination)
        {
            Console.WriteLine(string.Join(" ", combination));
        }
    }
}

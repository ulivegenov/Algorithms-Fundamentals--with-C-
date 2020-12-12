namespace _01.PermutationsWithoutRepetition
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            GetParmutations(input, 0);
        }

        private static void GetParmutations(string[] elements, int index)
        {
            if (index >= elements.Length)
            {
                Print(elements);
            }
            else
            {
                for (int i = index; i < elements.Length; i++)
                {
                    Swap(elements ,index, i);
                    GetParmutations(elements, index + 1);
                    Swap(elements, index, i);
                }

            }
        }

        private static void Swap(string[] elemments, int index, int i)
        {
            var temp = elemments[index];
            elemments[index] = elemments[i];
            elemments[i] = temp;
        }

        private static void Print(string[] elements)
        {
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

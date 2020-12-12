namespace _02.PermutationsWithRepetition
{
    using System;
    using System.Collections.Generic;

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
                GetParmutations(elements, index + 1);
                var swaped = new HashSet<string>() { elements[index] };
                for (int i = index + 1; i < elements.Length; i++)
                {
                    if (!swaped.Contains(elements[i]))
                    {
                        Swap(elements, index, i);
                        GetParmutations(elements, index + 1);
                        Swap(elements, index, i);
                        swaped.Add(elements[i]);
                    }
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

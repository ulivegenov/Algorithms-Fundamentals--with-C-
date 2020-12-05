namespace _01.RecursiveArraySum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] intput = Console.ReadLine().Split()
                                             .Select(int.Parse)
                                             .ToArray();

            Console.WriteLine(GetSum(intput, 0));
        }

        private static int GetSum(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                return 0;
            }

            return arr[index] + GetSum(arr, index + 1);
        }
    }
}

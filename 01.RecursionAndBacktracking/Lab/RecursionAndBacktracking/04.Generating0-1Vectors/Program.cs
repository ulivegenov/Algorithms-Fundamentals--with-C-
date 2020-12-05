namespace _04.Generating0_1Vectors
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int vectorLength = int.Parse(Console.ReadLine());
            int[] arr = new int[vectorLength];

            GeneratingVectors(arr, 0);
        }

        private static void GeneratingVectors(int[] arr, int index)
        {
            if (index > arr.Length - 1)
            {
                Console.WriteLine((string.Join("", arr)));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                arr[index] = i;
                GeneratingVectors(arr, index + 1);
            }
        }
    }
}

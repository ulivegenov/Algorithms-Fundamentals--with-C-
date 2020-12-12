namespace _07.NChooseKCount
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine((GetBinom(n, k)));
        }

        private static long GetBinom(int n, int k)
        {
            if (n <= 1)
            {
                return 1;
            }

            if (k == 0 || k == n)
            {
                return 1;
            }

            return GetBinom(n - 1, k) + GetBinom(n - 1, k - 1);
        }
    }
}

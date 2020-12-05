namespace _02.RecursiveFactorial
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(input));
        }

        private static long CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * CalculateFactorial(num - 1);
        }
    }
}

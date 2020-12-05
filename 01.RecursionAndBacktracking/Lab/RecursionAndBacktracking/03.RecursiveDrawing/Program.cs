namespace _03.RecursiveDrawing
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            DrawFigure(input);
        }

        public static void DrawFigure(int num)
        {
            if (num == 0)
            {
                return;
            }
            
            Console.WriteLine(new string('*', num));

            DrawFigure(num - 1);

            Console.WriteLine(new string('#', num));
        }
    }
}

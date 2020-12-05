namespace _07.PathsInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private const char VisitedPosition = 'v';
        private const char NotVisitedPosition = '-';
        private const char Wall = '*';
        private const char Exit = 'e';
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] lab = new char[rows, cols]; 
            

            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();

                for (int c = 0; c < line.Length; c++)
                {
                    lab[r, c] = line[c];
                }

            }

            List<char> directions = new List<char>();
            char direction = '\0';

            FindAllPaths(lab, 0, 0, directions, direction);
        }

        private static void FindAllPaths(char[,] lab, int row, int col, List<char> directions, char direction)
        {
            if (IsOutSide(lab, row, col) ||
                IsWall(lab, row, col) ||
                IsVisited(lab, row, col))
            {
                return;
            }

            directions.Add(direction);

            if (IsSalution(lab, row, col))
            {
                Console.WriteLine(string.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = VisitedPosition;

            FindAllPaths(lab, row - 1, col, directions, 'U');
            FindAllPaths(lab, row + 1, col, directions, 'D');
            FindAllPaths(lab, row, col - 1, directions, 'L');
            FindAllPaths(lab, row, col + 1, directions, 'R');

            lab[row, col] = NotVisitedPosition;
            directions.RemoveAt(directions.Count - 1);
        }

        private static bool IsSalution(char[,] lab, int row, int col)
        {
            return lab[row, col] == Exit;
        }

        private static bool IsVisited(char[,] lab, int row, int col)
        {
            return lab[row, col] == VisitedPosition;
        }

        private static bool IsWall(char[,] lab, int row, int col)
        {
            return lab[row, col] == Wall;
        }

        private static bool IsOutSide(char[,] lab, int row, int col)
        {
            return row < 0 ||
                   row >= lab.GetLength(0) ||
                   col < 0 ||
                   col >= lab.GetLength(1);
        }
    }
}

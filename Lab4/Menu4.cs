using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Menu4
    {
        public void StartCase4()
        {
            Console.Clear();
            GenerateGrid(grid);
            MaskGrid(mask);
            grid = FormatGrid(grid);
            bool start = false;
            start = GameProcess(mask, grid, start);
        }
        public int CoordInput(char var)
        {
            int coords = 0;
            bool right = false;
            while (!right)
            {
                if (var == 'x')
                {
                    Console.Write("Введите номер столбца (x): ");
                }
                else
                {
                    Console.Write("Введите номер строки (y): ");
                }
                right = int.TryParse(Console.ReadLine(), out coords);
                if (!right)
                {
                    Console.WriteLine("Введено некорректное значение номера.");
                }
                if (coords < 1 || coords > 10)
                {
                    Console.WriteLine("Номер принимает значение от 1 до 10.");
                    right = false;
                }
            }
            return coords;
        }
        public int[,] grid = new int[10, 10];
        public string[,] mask = new string[10, 10];
        public int[,] GenerateGrid(int[,] grid)
        {
            Random rng = new Random();
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = rng.Next(0, 10);
                }
            }
            return grid;
        }
        public string[,] MaskGrid(string[,] mask)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    mask[x, y] = "*";
                }
            }
            return mask;
        }
        public int[,] FormatGrid(int[,] grid)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    if (grid[x, y] == 9)
                    {
                        continue;
                    }
                    int mineCount = 0;
                    bool up = false;
                    bool down = false;
                    bool left = false;
                    bool right = false;

                    if (x - 1 >= 0)
                    {
                        up = true;
                    }
                    if (x + 1 < grid.GetLength(0))
                    {
                        down = true;
                    }
                    if (y - 1 >= 0)
                    {
                        left = true;
                    }
                    if (y + 1 < grid.GetLength(1))
                    {
                        right = true;
                    }

                    if (up)
                    {
                        if (grid[x - 1, y] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down)
                    {
                        if (grid[x + 1, y] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (left)
                    {
                        if (grid[x, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (right)
                    {
                        if (grid[x, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }

                    if (up && left)
                    {
                        if (grid[x - 1, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (up && right)
                    {
                        if (grid[x - 1, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down && right)
                    {
                        if (grid[x + 1, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down && left)
                    {
                        if (grid[x + 1, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    grid[x, y] = mineCount;
                }
            }
            return grid;
        }
        public void Coordinates(int[,] grid, string[,] mask)
        {
            Console.WriteLine(" x 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("y");
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                Console.Write(i + 1);
                if (!(i + 1 == 10))
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(" " + grid[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" x 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("y");
            for (int i = 0; i < mask.GetLength(0); i++)
            {
                Console.Write(i + 1);
                if (!(i + 1 == 10))
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < mask.GetLength(1); j++)
                {
                    Console.Write(" " + mask[i, j]);
                }
                Console.WriteLine();
            }
        }
        public bool GameProcess(string[,] mask, int[,] grid, bool gameOver)
        {
            Coordinates(grid, mask);
            Console.WriteLine();
            while (!gameOver)
            {
                int x = CoordInput('x');
                int y = CoordInput('y');
                if (grid[y - 1, x - 1] != 9)
                {
                    Console.Clear();
                    mask[y - 1, x - 1] = grid[y - 1, x - 1].ToString();
                    Coordinates(grid, mask);
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    mask[y - 1, x - 1] = grid[y - 1, x - 1].ToString();
                    Coordinates(grid, mask);
                    Console.WriteLine();
                    Console.WriteLine("Вы попали на клетку с миной! Попробуйте снова!");
                    Console.WriteLine("\r\n");
                    gameOver = true;
                }
            }
            return gameOver;
        }    
    }
}
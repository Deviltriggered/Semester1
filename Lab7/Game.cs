using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 5.
    /// </summary>
    internal class Game
    {
        private const int size = 10;
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 5.
        /// </summary>
        public void StartCase4()
        {
            Console.Clear();
            int[,] grid = new int[size, size];
            string[,] mask = new string[size, size];
            GenerateGrid(grid);
            MaskGrid(mask);
            grid = FormatGrid(grid);
            bool start = false;
            start = GameProcess(mask, grid, start);
        }
        /// <summary>
        /// Заполнение игрового поля случайными элементами.
        /// </summary>
        /// <param name="grid">Игровое поле.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Создание интерфейса пользователя.
        /// </summary>
        /// <param name="mask">Интерфейс пользователя.</param>
        /// <returns></returns>
        public string[,] MaskGrid(string[,] mask)
        {
            for (int x = 0; x < mask.GetLength(0); x++)
            {
                for (int y = 0; y < mask.GetLength(1); y++)
                {
                    mask[x, y] = "*";
                }
            }
            return mask;
        }
        /// <summary>
        /// Форматирование игрового поля.
        /// </summary>
        /// <param name="grid">Игровое поле.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Вывод обозначений элементов поля.
        /// </summary>
        /// <param name="grid">Игровое поле.</param>
        /// <param name="mask">Интерфейс пользователя.</param>
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
        /// <summary>
        /// Запуск игрового процесса.
        /// </summary>
        /// <param name="mask">Интерфейс пользователя.</param>
        /// <param name="grid">Игровое поле.</param>
        /// <param name="gameOver">Параметр проигрыша.</param>
        /// <returns></returns>
        public bool GameProcess(string[,] mask, int[,] grid, bool gameOver)
        {
            Coordinates(grid, mask);
            Console.WriteLine();
            while (!gameOver)
            {
                int x = Methods.CoordInput('x');
                int y = Methods.CoordInput('y');
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
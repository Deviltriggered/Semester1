using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 4.
    /// </summary>
    internal class Array
    {
        private int n;
        private int[] arr;
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Array()
        {
            this.n = 10;
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        public Array(int n)
        {
            this.n = n;
        }
        /// <summary>
        /// Заполнение массива случайными элементами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] CreateArray(int n)
        {
            int[] arr = new int[n];
            Random rng = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(-10, 10);
            }
            return arr;
        }
        /// <summary>
        /// Копирование массива.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] CopyArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
        /// <summary>
        /// Вывод элементов массива.
        /// </summary>
        /// <param name="arr">Массив.</param>
        public void PrintArray(int[] arr)
        {
            if (arr.Length > 100)
            {
                Console.WriteLine(">100 элементов, вывод отсутствует.");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\r\n");
            }
        }
        /// <summary>
        /// Сортировка "пузырьком".
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] BubbleSort(int[] arr)
        {
            int cache = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        cache = arr[i];
                        arr[i] = arr[j];
                        arr[j] = cache;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// Сортировка Шелла.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] ShellSort(int[] arr)
        {
            for (int interval = arr.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < arr.Length; i++)
                {
                    int current = arr[i];
                    int ind = i;
                    while (ind >= interval && arr[ind - interval] > current)
                    {
                        arr[ind] = arr[ind - interval];
                        ind -= interval;
                    }
                    arr[ind] = current;
                }
            }
            return arr;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        public void Comparison()
        {
            Console.Write("\r\n");
            arr = CreateArray(n);
            int[] arr1 = CopyArray(arr);
            Console.WriteLine("Неотсортированный массив:");
            PrintArray(arr);
            var timeBubble = new Stopwatch();
            timeBubble.Start();
            BubbleSort(arr);
            timeBubble.Stop();
            var timeShell = new Stopwatch();
            timeShell.Start();
            ShellSort(arr1);
            timeShell.Stop();
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(arr);
            Console.WriteLine("Время сортировки пузырьком: {0}", timeBubble.Elapsed);
            Console.WriteLine("Время сортировки Шелла: {0}", timeShell.Elapsed);
            if (timeBubble.Elapsed < timeShell.Elapsed)
            {
                Console.WriteLine("Сортировка пузырьком быстрее.");
            }
            else
            {
                Console.WriteLine("Сортировка Шелла быстрее.");
            }
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4 с выбором длины массива.
        /// </summary>
        public void StartCase3()
        {
            Console.Clear();
            Console.WriteLine("Выберите метод работы с длиной массива:");
            Console.WriteLine("1 - Длина массива по умолчанию (10)\r\n2 - Задать количество элементов вручную");
            int x = Methods.MenuInput();
            if (x == 1)
            {
                Comparison();
            }
            if (x == 2)
            {
                n = (int)Methods.ReadNumber('n');
                Comparison();
            }
        }
    }
}

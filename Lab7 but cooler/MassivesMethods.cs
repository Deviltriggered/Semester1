using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MassivesWork
    {
        private int n;
        private int[] arr;
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public MassivesWork()
        {
            this.n = 10;
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        public MassivesWork(int n)
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
            Random rnd = new Random();
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
        private void PrintArray(int[] arr)
        {
            if (arr.Length > 100)
            {
                Console.WriteLine("");
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
        public int[] Bubble(int[] arr)
        {
            int[] bubble = arr;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return bubble;
        }
        /// <summary>
        /// Сортировка Вставками.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] Insert(int[] arr)
        {
            int[] insert = arr;
            int ind;
            int curr;
            for (int i = 0; i < arr.Length; i++)
            {
                ind = i;
                curr = arr[i];
                while (ind > 0 && curr < arr[ind - 1])
                {
                    arr[ind] = arr[ind - 1];
                    ind--;
                }
                arr[ind] = curr;
            }
            return insert;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        private void Timing()
        {
            Console.Write("\r\n");
            arr = CreateArray(n);
            int[] arr1 = CopyArray(arr);
            Console.WriteLine("Неотсортированный массив:");
            PrintArray(arr);
            var BubbleTime = new Stopwatch();
            BubbleTime.Start();
            Bubble(arr);
            BubbleTime.Stop();
            var InsertTime = new Stopwatch();
            InsertTime.Start();
            Insert(arr1);
            InsertTime.Stop();
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(arr);
            Console.WriteLine("Время сортировки Пузырьком: {0}", BubbleTime.Elapsed);
            Console.WriteLine("Время сортировки Вставкой: {0}", InsertTime.Elapsed);
            if (BubbleTime.Elapsed < InsertTime.Elapsed)
            {
                Console.WriteLine("Сортировка Пузырьком быстрее.");
            }
            else
            {
                Console.WriteLine("Сортировка Вставкой быстрее.");
            }
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4 с выбором длины массива.
        /// </summary>
        public void MassivesSort()
        {
            Console.Clear();
            Console.WriteLine("Выберите метод работы с длиной массива:");
            Console.WriteLine("1 - Длина массива по умолчанию (10)\r\n2 - Задать количество элементов вручную");
            int x = ReadNumbers.ReadnumberInt("Ваш выбор: ");
            if (x == 1)
            {
                Timing();
            }
            if (x == 2)
            {
                n = (int)ReadNumbers.ReadnumberInt("Введите длину массива: ");
                Timing();
            }
        }
    }
}

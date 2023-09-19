using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Menu3
    {
        public void StartCase3()
        {
            Methods m3 = new Methods();
            double n = m3.ReadNumber('n');
            int[] arr = CreateArray(n);
            int[] arr1 = CopyArray(arr);
            Console.WriteLine("Неотсортированный массив:");
            PrintArray(arr);
            string timeBubble = Timer("Bubble Sort", arr);
            string timeShell = Timer("Shell Sort", arr1);
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(arr);
            Console.WriteLine("Время сортировки пузырьком: {0}", timeBubble);
            Console.WriteLine("Время сортировки Шелла: {0}", timeShell);
        }
        public string Timer(string Sort, int[] arr)
        {
            Stopwatch timer = new Stopwatch();
            if (Sort == "Bubble Sort")
            {
                timer.Start();
                BubbleSort(arr);
                timer.Stop();
            }
            else if (Sort == "Shell Sort")
            {
                timer.Start();
                ShellSort(arr);
                timer.Stop();
            }
            return timer.Elapsed.ToString();
        }
        public int[] CreateArray(double n)
        {
            int[] arr = new int[(int)n];
            Random rng = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(-10, 10);
            }
            return arr;
        }
        public int[] CopyArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            Random rng = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
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
    }
}

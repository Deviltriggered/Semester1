using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс для проверки чисел
    /// </summary>
    internal static class ReadNumbers
    {
        /// <summary>
        /// Проверка чисел Double
        /// </summary>
        /// <param name="one"> Ввод числа </param>
        /// <returns></returns>
        public static double ReadnumberDouble(string one)
        {
            double n = 0;
            bool isUrChoice = false;
            Console.Write("{0}", one);
            while (!isUrChoice)
            {
                isUrChoice = double.TryParse(Console.ReadLine(), out n);
                if (!isUrChoice)
                {
                    Console.Write("Это не число! повторите попытку: ");
                    Console.Write("{0}", one);
                }
            }
            return n;
        }
        /// <summary>
        /// Проверка чисел Int
        /// </summary>
        /// <param name="one"> Ввод числа </param>
        /// <returns></returns>
        public static int ReadnumberInt(string one)
        {
            int n = 0;
            bool isUrChoice = false;
            Console.Write("{0}", one);
            while (!isUrChoice)
            {
                isUrChoice = int.TryParse(Console.ReadLine(), out n);
                if (!isUrChoice)
                {
                    Console.Write("Это не число! повторите попытку: ");
                    Console.Write("{0}", one);
                }
            }
            return n;
        }
        /// <summary>
        /// Проверка числа и выхода за диапазон для игры Крестики-Нолики
        /// </summary>
        /// <returns></returns>
        public static int XoReadnumber()
        {
            bool isNumber = false;
            int range = 0;
            while (!isNumber)
            {
                isNumber = int.TryParse(Console.ReadLine(), out range);
                if (!isNumber)
                {
                    Console.Write("Это не число! Введите еще раз: ");
                }
                else if (range > 3)
                {
                    Console.WriteLine("Неверное значение (выход за диапазон)!");
                    isNumber = false;
                }
                else if (range < 1)
                {
                    Console.WriteLine("Неверное значение (выход за диапазон)!");
                    isNumber = false;
                }
            }
            return range;
        }
    }
}

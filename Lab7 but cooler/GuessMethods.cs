using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс для выполнения первой лабораторной работы.
    /// </summary>
    static class FirstCase
    {
        /// <summary>
        /// Вычисление значения функции.
        /// </summary>
        /// <param name="a"> Переменная a </param>
        /// <param name="b"> Переменная b </param>
        /// <returns></returns>
        public static double Calculation(double a, double b)
        {
            double f = Math.Round(Math.PI * ((Math.Log(Math.Pow(b, 5.0))) / (Math.Sin(a) - 1)));
            return f;
        }
        /// <summary>
        /// Отгадывание функции (выдается 3 попытки)
        /// </summary>
        /// <param name="f"> Значение функции </param>
        static void Game(double f)
        {
            Console.WriteLine("Угадайте значение функции. На это у вас 3 попытки: ");
            int s = 0;
            int z;
            for (int i = 1; i < 4; i++)
            {
                double answer = ReadNumbers.ReadnumberDouble("Введите ответ: ");
                if (answer == Math.Round(f))
                {
                    Console.WriteLine("Ответ верный!");
                    i = 5;
                }
                else
                {
                    Console.WriteLine("Ответ неправильный!");
                    Console.WriteLine("Количество попыток: {0}", z = 3 - i);
                    s = s + 1;
                }
            }
            if (s == 3)
            {
                Console.WriteLine("Вы проиграли!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Поздравляю! Вы выиграли!");
            }
        }
        /// <summary>
        /// Алгоритм выполнения первой лабораторной работы.
        /// </summary>
        public static void FunctionGame()
        {
            Console.Clear(); 
            Console.WriteLine("Чему равно значение функции: f = PI * (ln(b)^4) / (sin(a)-1) ?");
            double a = ReadNumbers.ReadnumberDouble("Введите a: ");
            double b = ReadNumbers.ReadnumberDouble("Введите b: ");
            double f = Calculation(a, b);
            Game(f);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 1.
    /// </summary>
    static class Guess
    {
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 1.
        /// </summary>
        public static void StartCase1()
        {
            Console.Clear();
            Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
            double a = Methods.ReadNumber('a');
            double b = Methods.ReadNumber('b');
            double c = Methods.ReadNumber('c');
            double answer = Maths(a, b);
            Jeopardy(answer);
            DivisionTest(answer, c);
        }
        /// <summary>
        /// Вычисление значения функции.
        /// </summary>
        /// <param name="a">Переменная a.</param>
        /// <param name="b">Переменная b.</param>
        /// <returns></returns>
        public static double Maths(double a, double b)
        {
            double answer = 0;
            double upper = Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(b, 4.0)));
            double lower = Math.Sin(Math.Pow(((Math.PI) / 2.0 + a), 2.0));
            double hugeAnswer = upper / lower;
            answer = Math.Round(hugeAnswer);
            return answer;
        }
        /// <summary>
        /// Отгадывание значения (3 попытки).
        /// </summary>
        /// <param name="answer">Значение функции.</param>
        /// <returns></returns>
        public static double Jeopardy(double answer)
        {
            int tries = 3;
            double userAnswer = 0;
            while (tries != 0)
            {
                bool isNumber = false;
                if (tries == 1)
                {
                    Console.WriteLine("Осталась {0} попытка.", tries);
                }
                else
                {
                    Console.WriteLine("Осталось {0} попытки.", tries);
                }
                while (!isNumber)
                {
                    Console.Write("Введите ответ: ");
                    isNumber = double.TryParse(Console.ReadLine(), out userAnswer);
                    if (!isNumber)
                    {
                        Console.WriteLine("Ответ может быть только числом.");
                    }
                }
                if (userAnswer == answer)
                {
                    Console.WriteLine("Ответ правильный!");
                    tries = 0;
                }
                else
                {
                    tries--;
                    Console.WriteLine("Ответ неправильный!");
                    if (tries == 0)
                    {
                        Console.WriteLine("Попытки закончились.");
                        Console.WriteLine("Правильный ответ: {0}", answer);
                    }
                }
            }
            return answer;
        }
        /// <summary>
        /// Проверка на делимость значения функции на переменную c.
        /// </summary>
        /// <param name="dividend">Делимое (Значение функции).</param>
        /// <param name="divisor">Делитель (Переменная с).</param>
        public static void DivisionTest(double dividend, double divisor)
        {
            double test = 0;
            try
            {
                test = (int)dividend / (int)divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("С введёнными значениями переменной c происходит деление на ноль.");
                Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться назад.");
                Console.ReadKey();
            }
            Console.WriteLine("\r\n");
        }
    }
}

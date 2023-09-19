using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Menu1
    {
        public void StartCase1()
        {
            Methods m1 = new Methods();
            Console.Clear();
            Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
            double a = m1.ReadNumber('a');
            double b = m1.ReadNumber('b');
            double c = m1.ReadNumber('c');
            double answer = Maths(a, b);
            Jeopardy(answer);
            DivisionTest(answer, c);
        }
        public double Maths(double a, double b)
        {
            double answer = 0;
            double upper = Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(b, 4.0)));
            double lower = Math.Sin(Math.Pow(((Math.PI) / 2.0 + a), 2.0));
            double hugeAnswer = upper / lower;
            answer = Math.Round(hugeAnswer);
            return answer;
        }
        public double Jeopardy(double answer)
        {
            int tries = 3;
            bool isNumber = false;
            double userAnswer = 0;
            while (tries != 0)
            {
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
        public void DivisionTest(double dividend, double divisor)
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

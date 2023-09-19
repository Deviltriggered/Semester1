using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Methods
    {
        public double ReadNumber(char var)
        {
            bool isNumber = false;
            double n = 0;
            if (var == 'b')
            {
                while (!isNumber || n == 0)
                {
                    Console.Write("Введите значение переменной " + var + ": ");
                    isNumber = double.TryParse(Console.ReadLine(), out n);
                    if (n == 0)
                    {
                        if (!isNumber)
                        {
                            Console.WriteLine("Значение переменной " + var + " может быть только числом.");
                        }
                        else
                        {
                            Console.WriteLine("Значение переменной " + var + " не может быть равно 0.");
                        }
                    }
                }
            }
            else if (var == 'n')
            {
                while (!isNumber || n <= 1)
                {
                    Console.Write("Введите длину массива: ");
                    isNumber = double.TryParse(Console.ReadLine(), out n);
                    if (!isNumber)
                    {
                        Console.WriteLine("Значение длины массива может быть только числом.");
                    }
                    else if (n <= 1)
                    {
                        Console.WriteLine("Длина массива должна быть больше 1.");
                    }
                }
            }
            else
            {
                while (!isNumber)
                {
                    Console.Write("Введите значение переменной " + var + ": ");
                    isNumber = double.TryParse(Console.ReadLine(), out n);
                    if (!isNumber)
                    {
                        Console.WriteLine("Значение переменной " + var + " может быть только числом.");
                    }
                }
            }
            return n;
        }
        public void ErrorMsg()
        {
            Console.Clear();
            Console.WriteLine("Что-то пошло не так...");
            Console.WriteLine("Введено не число // число, выходящее за пределы доступных пунктов.");
            Console.WriteLine("Попробуйте снова!");
            Console.WriteLine("\r\n");
        }
    }
}

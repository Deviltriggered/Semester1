using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /// <summary>
    /// Класс, содержащий методы для проверки вводимых данных.
    /// </summary>
    static class Methods
    {
        /// <summary>
        /// Ввод одного числа
        /// </summary>
        /// <param name="var">Буква, обозначающая вводимую переменную.</param>
        /// <returns></returns>
        public static double ReadNumber(char var)
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
        /// <summary>
        /// Ввод координат игрового поля.
        /// </summary>
        /// <param name="var">Обозначение координаты.</param>
        /// <returns></returns>
        public static int CoordInput(char var)
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
        /// <summary>
        /// Ввод пункта меню.
        /// </summary>
        /// <returns></returns>
        public static int MenuInput()
        {
            int n = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.Write("Выберите пункт: ");
                isNumber = int.TryParse(Console.ReadLine(), out n);
                if (!isNumber)
                {
                    Console.WriteLine("Значение пункта может быть только числом.");
                }
                else if (n < 1 || n > 2)
                {
                    Console.WriteLine("Значение пункта выходит за пределы допустимых значений.");
                    isNumber = false;
                }
            }
            return n;
        }
        /// <summary>
        /// Ввод строк.
        /// </summary>
        /// <param name="var">Номер вводимой строки.</param>
        /// <returns></returns>
        public static string ReadString(char var)
        {
            string userString = "";
            bool emptyStr = false;
            while (!emptyStr)
            {
                if (var == '1')
                {
                    Console.WriteLine("Введите первую строку:");
                    userString = Console.ReadLine();
                }
                if (var == '2')
                {
                    Console.WriteLine("Введите вторую строку:");
                    userString = Console.ReadLine();
                }
                if (var == '3')
                {
                    Console.WriteLine("Введите третью строку:");
                    userString = Console.ReadLine();
                }
                if (userString == "")
                {
                    Console.WriteLine("Строка не может быть пустой.");
                }
                else
                {
                    emptyStr = true;
                }
            }
            return userString;
        }
    }
}
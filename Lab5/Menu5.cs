using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Menu5
    {
        public string strFirst = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        public string strSecDotOne = "Быть может, вся Природа – мозаика цветов?";
        public string strSecDotTwo = "Быть может, вся Природа – различность голосов?";
        public int WhatWeDoin()
        {
            int n = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.Write("Введите номер: ");
                isNumber = int.TryParse(Console.ReadLine(), out n);
                if (!isNumber)
                {
                    Console.WriteLine("Значение номера может быть только числом.");
                }
                else if (n < 1 || n > 2)
                {
                    Console.WriteLine("Значение номера выходит за пределы допустимых значений.");
                    isNumber = false;
                }
            }
            return n;
        }
        public void StartCase5()
        {
            Console.Clear();
            int n = 0;
            Console.WriteLine("1 - работа с тестовыми строками\r\n2 - работа со строками, введёнными вручную");
            n = WhatWeDoin();
            if (n == 1)
            {
                Console.WriteLine("\r\n");
                Console.WriteLine(strFirst);
                Console.Write("\r\n");
                LetterCounter(strFirst);
                CasesCounter(strFirst);
                Console.Write("\r\n");
                Console.WriteLine(strSecDotOne);
                Console.WriteLine(strSecDotTwo);
                Console.Write("\r\n");
                Similarities(strSecDotOne, strSecDotTwo);
                Console.WriteLine("\r\n");
            }
            if (n == 2)
            {
                string FirstStr = ReadString('1');
                string SecStrDotOne = ReadString('2');
                string SecStrDotTwo = ReadString('3');
                Console.WriteLine("\r\n");
                Console.WriteLine(FirstStr);
                Console.Write("\r\n");
                LetterCounter(FirstStr);
                CasesCounter(FirstStr);
                Console.Write("\r\n");
                Console.WriteLine(SecStrDotOne);
                Console.WriteLine(SecStrDotTwo);
                Console.Write("\r\n");
                Similarities(SecStrDotOne, SecStrDotTwo);
                Console.WriteLine("\r\n");
            }
        }
        public string ReadString(char var)
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
        public void LetterCounter(string str)
        {
            string consonants = "бвгджзклмнпрстфхцчшщйъьБВГДЖЗКЛМНПРСТФХЦЧШЩЙЪЬ";
            string vowels = "аеёиоуэюяАЕЁИОУЭЮЯ";
            int consonantsCounter = 0;
            int vowelsCounter = 0;
            foreach (char ch in str)
            {
                if (consonants.Contains(ch))
                {
                    consonantsCounter++;
                }
                if (vowels.Contains(ch))
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine("Количество гласных букв: {0}, согласных: {1}", vowelsCounter, consonantsCounter);
        }
        public void CasesCounter(string str)
        {
            string Cases = "Аа";
            int CasesCounter = 0;
            foreach (char ch in str)
            {
                if (Cases.Contains(ch))
                {
                    CasesCounter++;
                }
            }
            Console.WriteLine("Количество букв А(а): {0}", CasesCounter);
        }
        public void Similarities(string str, string str1)
        {
            char[] equals = str.ToCharArray();
            char[] equals1 = str1.ToCharArray();
            string symbols = "@#$%^&*()_+№;:?-=<>,./!|";
            int similar = 0;
            for (int i = 0; i < equals.Length; i++)
            {
                if (equals.Length > equals1.Length)
                {
                    if (char.IsLetter(equals[i]) || symbols.Contains(equals[i]))
                    {
                        if (equals[i] == equals1[i])
                        {
                            similar++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (char.IsLetter(equals1[i]) || symbols.Contains(equals1[i]))
                    {
                        if (equals1[i] == equals[i])
                        {
                            similar++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Совпадает первых символов: {0}", similar);
        }
    }
}

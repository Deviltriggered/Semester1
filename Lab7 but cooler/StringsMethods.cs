using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс для шестой лабораторной работы.
    /// </summary>
    internal class SevenLab
    {
        private const string ThirdString = "Варкалось. Хливкие шорьки \r\nПырялись по наве, \r\nИ хрюкотали зелюки, \r\nКак мюмзики в мове. \r\nО бойся Бармаглота, сын! \r\nОн так свирлеп и дик, \r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        private const string stringOne = "Быть может, вся Природа – мозаика цветов?";
        private const string stringTwo = "Быть может, вся Природа – различность голосов?";
        private const string RealString = "\r\nВот 1 (иль единица),\r\nОчень тонкая, как спица,\r\nА вот это цифра 2.\r\nПолюбуйся, какова:\r\nВыгибает двойка шею,\r\nВолочится хвост за нею.\r\nА за двойкой - посмотри -\r\nВыступает цифра 3.\r\nТройка - третий из значков -\r\nСостоит из двух крючков.";
        private string strThree;
        private string firstStr;
        private string secStr;
        private string strReal;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public SevenLab()
        {
            this.strThree = ThirdString;
            this.firstStr = stringOne;
            this.secStr = stringTwo;
            this.strReal = RealString;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="strThree"> Третья строчка </param>
        /// <param name="firstStr"> Первая строчка </param>
        /// <param name="secStr"> Вторая строчка </param>
        /// <param name="strReal"> Стихотворение </param>
        public SevenLab(string strThree, string firstStr, string secStr, string strReal)
        {
            this.strThree = strThree;
            this.firstStr = firstStr;
            this.secStr = secStr;
            this.strReal = strReal;
        }
        /// <summary>
        /// Выбор задания
        /// </summary>
        public void Strings()
        {
            bool menu = false;
            while (!menu)
            {
                Console.Clear();
                Console.WriteLine("1 - Посчитать количество слов в строке.");
                Console.WriteLine("2 - Посчитать количество цифр в строке.");
                Console.WriteLine("3 - Даны две строки. У них одинаковые начала. Вывести на экран, сколько первых символов этих строк совпадают.");
                int choice = ReadNumbers.ReadnumberInt("Введите номер задания: ");
                switch (choice)
                {
                    case 1:
                        bool choice1 = false;
                        while (!choice1)
                        {
                            SevenTaskMenu();
                            int num1 = ReadNumbers.ReadnumberInt("Выберите вариант: ");
                            Console.Clear();
                            switch (num1)
                            {
                                case 1:
                                    Console.WriteLine(strThree);
                                    CountWords(strThree);
                                    Console.ReadKey();
                                    choice1 = true;
                                    break;
                                case 2:
                                    string writestring = WriteSTR();
                                    CountWords(writestring);
                                    Console.ReadKey();
                                    choice1 = true;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        bool choice2 = false;
                        while (!choice2)
                        {
                            SevenTaskMenu();
                            int num2 = ReadNumbers.ReadnumberInt("Выберите вариант: ");
                            Console.Clear();
                            switch (num2)
                            {
                                case 1:
                                    Console.WriteLine(strReal);
                                    SumNumbers(strReal);
                                    Console.ReadKey();
                                    choice2 = true;
                                    break;
                                case 2:
                                    string writestring = WriteSTR();
                                    SumNumbers(writestring);
                                    Console.ReadKey();
                                    choice2 = true;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        bool choice3 = false;
                        while (!choice3)
                        {
                            SevenTaskMenu();
                            int num3 = ReadNumbers.ReadnumberInt("Выберите вариант: ");
                            Console.Clear();
                            switch (num3)
                            {
                                case 1:
                                    Console.WriteLine(firstStr);
                                    Console.WriteLine(secStr);
                                    Coincidence(firstStr, secStr);
                                    Console.ReadKey();
                                    choice3 = true;
                                    break;
                                case 2:
                                    string writestring1 = WriteSTR();
                                    string writestring2 = WriteSTR();
                                    Coincidence(writestring1, writestring2);
                                    Console.ReadKey();
                                    choice3 = true;
                                    break;
                            }
                        }
                        break;
                }
                Console.Clear();
                menu = true;
            }
        }
        /// <summary>
        /// Выбор способа введения строки
        /// </summary>
        public static void SevenTaskMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Базовая строка");
            Console.WriteLine("2 - Введение строки пользователем");
        }
        /// <summary>
        /// Подсчет слов в строке
        /// </summary>
        /// <param name="count"> Длина строки </param>
        public static void CountWords(string count)
        {
            int s = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (i < count.Length - 1)
                {
                    bool a = char.IsLetter(count[i]);
                    bool b = char.IsLetter(count[i + 1]);
                    bool c = char.IsWhiteSpace(count[i + 1]);
                    if (a && (!b || c))
                    {
                        s++;
                    }
                }
            }
            Console.WriteLine("Количество слов: " + s);
        }
        /// <summary>
        /// Подсчет цифр в строке
        /// </summary>
        /// <param name="words"> Длина строки </param>
        public static void SumNumbers(string words)
        {
            int s1 = 0;
            string nums = "0123456789";
            for (int i = 0; i < words.Length; i++)
            {
                if (nums.Contains(words[i]))
                {
                    s1++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество цифр в строке: " + s1);
        }
        /// <summary>
        /// Подсчет количества одинаковых символов
        /// </summary>
        /// <param name="word"> Длина первой строки </param>
        /// <param name="wword"> Длина второй строки </param>
        public static void Coincidence(string word, string wword)
        {
            int s = 0;
            if (word.Length > wword.Length)
            {
                for (int i = 0; i < wword.Length; i++)
                {
                    if (word[i] == wword[i])
                    {
                        s++;
                    }
                    else
                        i = wword.Length;
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == wword[i])
                    {
                        s++;
                    }
                    else
                        i = word.Length;
                }
            }
            Console.WriteLine("Ответ: " + s + " символов совпадает");
        }
        /// <summary>
        /// Ввод строки вручную
        /// </summary>
        /// <returns></returns>
        public static string WriteSTR()
        {
            Console.Write("Введите строку: ");
            string write = Console.ReadLine();
            Console.WriteLine("Строка: " + write);
            return write;
        }
    }
}

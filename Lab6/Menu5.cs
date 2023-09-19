using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Класс для выполнения лабораторной работы 6.
    /// </summary>
    internal class Menu5
    {
        private const string strFirst = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        private const string strSecDotOne = "Быть может, вся Природа – мозаика цветов?";
        private const string strSecDotTwo = "Быть может, вся Природа – различность голосов?";
        private string firstStr;
        private string secStrDotOne;
        private string secStrDotTwo;
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Menu5()
        {
            this.firstStr = strFirst;
            this.secStrDotOne = strSecDotOne;
            this.secStrDotTwo = strSecDotTwo;
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="firstStr">Первая строка.</param>
        /// <param name="secStrDotOne">Вторая строка.</param>
        /// <param name="secStrDotTwo">Третья строка.</param>
        public Menu5(string firstStr, string secStrDotOne, string secStrDotTwo)
        {
            this.firstStr = firstStr;
            this.secStrDotOne = secStrDotOne;
            this.secStrDotTwo = secStrDotTwo;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 6.
        /// </summary>
        private void RunTasks()
        {
            Console.Write("\r\n");
            Console.WriteLine(firstStr);
            Console.Write("\r\n");
            LetterCounter(firstStr);
            CasesCounter(firstStr);
            Console.Write("\r\n");
            Console.WriteLine(secStrDotOne);
            Console.WriteLine(secStrDotTwo);
            Console.Write("\r\n");
            Similarities(secStrDotOne, secStrDotTwo);
            Console.WriteLine("\r\n");
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 6 с выбором режима работы.
        /// </summary>
        public void StartCase5()
        {
            Console.Clear();
            int n = 0;
            Console.WriteLine("1 - работа с тестовыми строками\r\n2 - работа со строками, введёнными вручную");
            n = Methods.MenuInput();
            switch (n)
            {
                case 1:
                    RunTasks();
                    break;
                case 2:
                    firstStr = Methods.ReadString('1');
                    secStrDotOne = Methods.ReadString('2');
                    secStrDotTwo = Methods.ReadString('3');
                    RunTasks();
                    break;
            }
        }
        /// <summary>
        /// Подсчёт гласных и согласных букв в строке.
        /// </summary>
        /// <param name="str">Строка.</param>
        private void LetterCounter(string str)
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
        /// <summary>
        /// Подсчёт заглавных и строчных букв А(а) в строке.
        /// </summary>
        /// <param name="str">Строка.</param>
        private void CasesCounter(string str)
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
        /// <summary>
        /// Подсчёт одинаковых первых символов в двух строках.
        /// </summary>
        /// <param name="str">Первая строка.</param>
        /// <param name="str1">Вторая строка.</param>
        private void Similarities(string str, string str1)
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

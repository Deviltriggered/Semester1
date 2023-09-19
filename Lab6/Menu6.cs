using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Класс для выхода из программы.
    /// </summary>
    static class Menu6
    {
        /// <summary>
        /// Выполнение алгоритма выхода из программы.
        /// </summary>
        /// <returns></returns>
        public static bool StartCase6()
        {
            bool exitBool = false;
            bool exit = false;
            while (!exitBool)
            {
                Console.Clear();
                Console.WriteLine("Вы действительно хотите выйти?");
                Console.WriteLine("Д - Да\r\nН - Нет");
                Console.Write("Выберите пункт: ");
                string exitChoice = Console.ReadLine();
                if ((exitChoice == "Д") || (exitChoice == "д"))
                {
                    exitBool = true;
                    exit = true;
                }
                if ((exitChoice == "Н") || (exitChoice == "н"))
                {
                    exitBool = true;
                }
            }
            Console.WriteLine("\r\n");
            return exit;
        }
    }
}

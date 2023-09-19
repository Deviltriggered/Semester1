using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Menu6
    {
        public bool StartCase6()
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

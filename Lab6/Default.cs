using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Класс для вывода ошибок в выборе пункта меню.
    /// </summary>
    static class Default
    {
        /// <summary>
        /// Вывод ошибки в пункте выбора меню.
        /// </summary>
        public static void StartDefault()
        {
            Console.Clear();
            Console.WriteLine("Что-то пошло не так...");
            Console.WriteLine("Введено не число // число, выходящее за пределы доступных пунктов.");
            Console.WriteLine("Попробуйте снова!");
            Console.WriteLine("\r\n");
        }
    }
}

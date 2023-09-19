namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1 - Отгадай ответ\r\n2 - Об авторе (Фамилия И.О., группа)\r\n3 - Выход");
                Console.Write("Выберите пункт: ");
                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);
                bool exitBool = false;
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        bool uno = false;
                        bool dos = false;
                        bool tres = false;
                        bool cuatro = false;
                        Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
                        double a = 0;
                        while (!uno)
                        {
                            Console.Write("Введите корректное значение a: ");
                            uno = double.TryParse(Console.ReadLine(), out a);
                            if (!uno)
                            {
                                Console.WriteLine("Значение a может быть только числом.");
                            }
                        }
                        double b = 0;
                        while ((!uno) || (!dos))
                        {
                            Console.Write("Введите корректное значение b: ");
                            uno = double.TryParse(Console.ReadLine(), out b);
                            if (b == 0)
                            {
                                if (!uno)
                                {
                                    Console.WriteLine("Значение b может быть только числом.");
                                }
                                else
                                {
                                    Console.WriteLine("Значение b не может быть равно 0.");
                                }
                            }
                            else
                            {
                                dos = true;
                            }
                        }
                        int c = 0;
                        while (!tres)
                        {
                            Console.Write("Введите корректное значение c: ");
                            tres = int.TryParse(Console.ReadLine(), out c);
                            if (!tres)
                            {
                                Console.WriteLine("Значение c может быть только числом.");
                            }
                        }
                        double upper = Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(b, 4.0)));
                        double lower = Math.Sin(Math.Pow(((Math.PI) / 2.0 + a), 2.0));
                        double answer = upper / lower;
                        double rounded = Math.Round(answer);
                        double userAnswer = 0;
                        while (!cuatro)
                        {
                            Console.Write("Введите ответ: ");
                            cuatro = double.TryParse(Console.ReadLine(), out userAnswer);
                            if (!cuatro)
                            {
                                Console.WriteLine("Ответ может быть только числом.");
                            }
                        }
                        if (userAnswer == rounded)
                        {
                            Console.WriteLine("Ответ правильный!");
                        }
                        else
                        {
                            Console.WriteLine("Ответ неправильный!\r\nПравильный ответ: {0}\r\nОкруглённый: {1}", answer, rounded);
                        }
                        int testAns = (int)rounded;
                        int test = 0;
                        try
                        {
                            test = testAns / c;
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("С введёнными значениями переменной c происходит деление на ноль.");
                            Console.WriteLine("Нажмите на любую клавишу, чтобы вернуться назад");
                            Console.ReadKey();
                        }
                        Console.WriteLine("\r\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ФИО автора: Кудряшов Алексей Викторович\r\nГруппа: 6101-090301D");
                        Console.WriteLine("\r\n");
                        break;
                    case 3:
                        while (!exitBool)
                        {
                            Console.Clear();
                            Console.WriteLine("Вы действительно хотите выйти?");
                            Console.WriteLine("Д - Да\r\nН - Нет");
                            Console.Write("Выберите пункт: ");
                            String exitChoice = Console.ReadLine();
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
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Что-то пошло не так...");
                        Console.WriteLine("Введено не число // число, выходящее за пределы доступных пунктов.");
                        Console.WriteLine("Попробуйте снова!");
                        Console.WriteLine("\r\n");
                        break;

                }
            }
        }
    }
}
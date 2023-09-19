using System.Transactions;

namespace Lab2
{
    internal class Program
    {
        static void AuthorInfo()
        {
            Console.Clear();
            Console.WriteLine("ФИО автора: Кудряшов Алексей Викторович\r\nГруппа: 6101-090301D");
            Console.WriteLine("\r\n");
        }
        static void ErrorMsg()
        {
            Console.Clear();
            Console.WriteLine("Что-то пошло не так...");
            Console.WriteLine("Введено не число // число, выходящее за пределы доступных пунктов.");
            Console.WriteLine("Попробуйте снова!");
            Console.WriteLine("\r\n");
        }
        static double ReadNumber(char var)
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
        static double Maths(double a, double b)
        {
            double answer = 0;
            double upper = Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(b, 4.0)));
            double lower = Math.Sin(Math.Pow(((Math.PI) / 2.0 + a), 2.0));
            double hugeAnswer = upper / lower;
            answer = Math.Round(hugeAnswer);
            return answer;
        }
        static double Jeopardy(double answer)
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
        static void DivisionTest(double dividend, double divisor)
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
        static bool ExitOption(bool exit)
        {
            bool exitBool = false;
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
                        Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
                        double a = ReadNumber('a');
                        double b = ReadNumber('b');
                        double c = ReadNumber('c');
                        double answer = Maths(a, b);
                        Jeopardy(answer);
                        DivisionTest(answer, c);
                        break;
                    case 2:
                        AuthorInfo();
                        break;
                    case 3:
                        exit = ExitOption(exit);
                        break;
                    default:
                        ErrorMsg();
                        break;

                }
            }
        }
    }
}
using System.Diagnostics;

namespace Lab3
{
    internal class Program
    {
        static void StartCase1()
        {
            Console.Clear();
            Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
            double a = ReadNumber('a');
            double b = ReadNumber('b');
            double c = ReadNumber('c');
            double answer = Maths(a, b);
            Jeopardy(answer);
            DivisionTest(answer, c);
        }
        static void StartCase2()
        {
            Console.Clear();
            Console.WriteLine("ФИО автора: Кудряшов Алексей Викторович\r\nГруппа: 6101-090301D");
            Console.WriteLine("\r\n");
        }
        static void StartCase3()
        {
            double n = ReadNumber('n');
            int[] arr = CreateArray(n);
            int[] arr1 = CopyArray(arr);
            Console.WriteLine("Неотсортированный массив:");
            PrintArray(arr);
            string timeBubble = Timer("Bubble Sort", arr);
            string timeShell = Timer("Shell Sort", arr1);
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(arr);
            Console.WriteLine("Время сортировки пузырьком: {0}", timeBubble);
            Console.WriteLine("Время сортировки Шелла: {0}", timeShell);
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
        static string Timer(string Sort, int[] arr)
        {
            Stopwatch timer = new Stopwatch();
            if (Sort == "Bubble Sort")
            {
                timer.Start();
                BubbleSort(arr);
                timer.Stop();
            }
            else if (Sort == "Shell Sort")
            {
                timer.Start();
                ShellSort(arr);
                timer.Stop();
            }
            return timer.Elapsed.ToString();
        }
        static int[] CreateArray(double n)
        {
            int[] arr = new int[(int)n];
            Random rng = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(-10, 10);
            }
            return arr;
        }
        static int[] CopyArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            Random rng = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
        static void PrintArray(int[] arr)
        {
            if (arr.Length > 100)
            {
                Console.WriteLine(">100 элементов, вывод отсутствует.");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\r\n");
            }
        }
        static int[] BubbleSort(int[] arr)
        {
            int cache = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        cache = arr[i];
                        arr[i] = arr[j];
                        arr[j] = cache;
                    }
                }
            }
            return arr;
        }
        static int[] ShellSort(int[] arr)
        {
            for (int interval = arr.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < arr.Length; i++)
                {
                    int current = arr[i];
                    int ind = i;
                    while (ind >= interval && arr[ind - interval] > current)
                    {
                        arr[ind] = arr[ind - interval];
                        ind -= interval;
                    }
                    arr[ind] = current;
                }
            }
            return arr;
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
                Console.WriteLine("1 - Отгадай ответ\r\n2 - Об авторе (Фамилия И.О., группа)\r\n3 - Сортировка\r\n4 - Выход");
                Console.Write("Выберите пункт: ");
                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        StartCase1();
                        break;
                    case 2:
                        StartCase2();
                        break;
                    case 3:
                        StartCase3();
                        break;
                    case 4:
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
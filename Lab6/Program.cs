namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1 - Отгадай ответ\r\n2 - Об авторе (Фамилия И.О., группа)\r\n3 - Сортировка\r\n4 - Сапёр\r\n5 - Работа со строками\r\n6 - Выход");
                Console.Write("Выберите пункт: ");
                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Menu1.StartCase1();
                        break;
                    case 2:
                        Menu2.StartCase2();
                        break;
                    case 3:
                        Menu3 menuThree = new Menu3();
                        menuThree.StartCase3();
                        break;
                    case 4:
                        Menu4 menuFour = new Menu4();
                        menuFour.StartCase4();
                        break;
                    case 5:
                        Menu5 menuFive = new Menu5();
                        menuFive.StartCase5();
                        break;
                    case 6:
                        exit = Menu6.StartCase6();
                        break;
                    default:
                        Default.StartDefault();
                        break;
                }
            }
        }
    }
}
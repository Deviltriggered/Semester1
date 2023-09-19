namespace Lab5
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
                Methods Method = new Methods();
                switch (choice)
                {
                    case 1:
                        Menu1 menuOne = new Menu1();
                        menuOne.StartCase1();
                        break;
                    case 2:
                        Menu2 menuTwo = new Menu2();
                        menuTwo.StartCase2();
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
                        Menu6 menuSix = new Menu6();
                        exit = menuSix.StartCase6();
                        break;
                    default:
                        Method.ErrorMsg();
                        break;
                }
            }
        }
    }
}
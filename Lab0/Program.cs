namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменных a и b:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно значение функции: (cos^7(pi) + sqrt(ln(b^4)) / sin(pi/2 + a)^2?");
            double Upper = Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(b, 4.0)));
            double Lower = Math.Sin(Math.Pow(((Math.PI) / 2.0 + a), 2.0));
            double Answer = Upper / Lower;
            Console.Write("Введите ответ: ");
            double UserAnswer = double.Parse(Console.ReadLine());
            //if (UserAnswer == Answer)
                //Console.WriteLine("Ответ правильный");
            //else
                //Console.WriteLine("Ответ неправильный")
            Console.WriteLine("Правильный ответ: {0}", Answer);
        }
    }
}
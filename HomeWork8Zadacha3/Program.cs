using System;

namespace HomeWork8Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRect = new Rectangle();
            Console.Write("введите длинну:\t");
            firstRect.A = ChekVal();
            Console.Write("введите ширину:\t");
            firstRect.B = ChekVal();
            firstRect.Info();
            firstRect.Perimetr();
            firstRect.Arrey();
            if (firstRect.IsRectangle)
                Console.WriteLine("заданный прямоугольник являеться квадратом");
            else
                Console.WriteLine("заданный прямоугольник не являеться квадратом");
        }
        static int ChekVal()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                    return x;
                else
                    Console.Write("не верные данные! повторите ввод:\t");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8Zadacha3
{
    class Rectangle
    {
        private int a, b;
        public Rectangle() { }
        public Rectangle(int a, int b)
        {
        }

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                    a = 1;
            }

        }
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                    b = 1;
            }

        }
        public bool IsRectangle
        {
            get
            {
                if (a == b)
                    return true;
                return false;
            }
        }
        public void Info()
        {
            Console.WriteLine($"длинна прямоугольника равна {a} ширина равна {b}");
        }
        public void Perimetr()
        {
            int P = (a + b) * 2;
            Console.WriteLine($"периметр прямоугольника равен {P}");
        }
        public void Arrey()
        {
            int S = a * b;
            Console.WriteLine($"площадь прямоугольнгика равна {S}");
        }
    }
}

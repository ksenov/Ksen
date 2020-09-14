using System;

namespace ТРПО__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int B,A,C;
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());
            A = a + b;
            B = c - a;
            C = a + b + c;
            b = B;
            c = C;
            a = A;
            Console.WriteLine(a+","+b+","+c);
            Console.WriteLine("Первый commit");
        }
    }
}

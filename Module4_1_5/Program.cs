using System;

namespace Module4_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную A, B, C, Y по порядку");
            int A = 1;
            int B = 3;
            double X = 5;
            double Y = 5;

            bool C = ( A < B ) | ( X > Y );
            Console.WriteLine("{0}", C);
            Console.ReadKey();
        }
    }
}

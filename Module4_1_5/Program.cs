using System;

namespace Module4_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную A, B, C, Y по порядку");
            var a = 6;
            var b = 7;

            var c = (a > b) ^ (a != b);
            Console.WriteLine("{0}", c);
            Console.ReadKey();
        }
    }
}

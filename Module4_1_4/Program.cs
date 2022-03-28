using System;

namespace Module4_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную А");
            string A = Console.ReadLine();
            Console.WriteLine("Введите переменную B");
            string B = Console.ReadLine();
            bool C = A != B;
            Console.WriteLine("Результат {0}", C);
        }
    }
}

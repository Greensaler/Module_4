using System;

namespace Module_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // это кортеж, можно вводить любые данные и обращаться к ним по имени
            (string name, int age) anketa;
            (string ; ) Pet;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.ReadKey();
        }
    }
}

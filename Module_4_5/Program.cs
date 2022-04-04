using System;

namespace Module_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();

            Console.WriteLine("Длина вашего логина");
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Имеете ли вы питомца, Да или Нет?");
            
            var result = Console.ReadLine();

            if ( result == "Да" )
            {
                User.HasPet = true;
            }
            else 
            {
                User.HasPet = false;
            }

            User.favcolors = new string[3];
            Console.WriteLine("Напишите три ваших любимых цвета на алнглийском маленькими буквами");
            for ( int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
                      
            Console.WriteLine("Введите ваш возраст цифрами?");
            User.Age = double.Parse(Console.ReadLine());



        }
    }
}

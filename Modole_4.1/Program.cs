using System;

namespace Modole_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            var result = A == B;
            Console.WriteLine(result);


            int AA = 1 ;
            int BB = 2;
            double XX = 5;
            double YY = 4;
            var C = (AA > BB) | (XX > YY);
            Console.WriteLine(C) ;

            double X1 = 6;
            double Y2 = 7;
            var C1 = (X1 < Y2) | (X1 != Y2);
            Console.WriteLine(C1);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            // есть полезная функция switch 
            // break обязателен, но можно использовать 
            // return - выход из метода
            // goto case - позволяет перейти к другому условию
            // throw применяется для выбора ошибок
            // default - это если значение не соответствует ни одному из условий, но его можно пропустить

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color2 = Console.ReadLine();

            switch (color2)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
            }


        }
    }
}

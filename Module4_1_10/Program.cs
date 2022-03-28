using System;

namespace Module4_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 12;
            var b = 11;

            if (a == b)
            {
                Console.WriteLine("Условие истино");
            }
            else if (b < 10)
            {
                
                Console.WriteLine("Значение b = {0} меньше 10", b);

            }
            else if (b == 10)
            {

                Console.WriteLine("Значение b = {0} равно 10", b);

            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }
           
        }
    }
}

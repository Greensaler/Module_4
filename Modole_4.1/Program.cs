﻿using System;

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
            Console.ReadKey();
           
           
        }
    }
}

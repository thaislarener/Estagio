﻿using System;

namespace proj1Aula2{
    class Program{
        static void Main(string[] args){
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;

            double A = Math.Sqrt(x);
            double B = Math.Sqrt(y);
            double C = Math.Sqrt(25.0);

            Console.WriteLine("Raiz quadrada de x = " + A);
            Console.WriteLine("Raiz quadrada de y = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);
            Console.WriteLine();

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine("x elevado a y = " + A);
            Console.WriteLine("x elevado a 2.0 = " + B);
            Console.WriteLine("5.0 elevado a 2.0 = " + C);
            Console.WriteLine();

            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("Valor absoluto de y = " + A);
            Console.WriteLine("Valor absoluto de z = " + B);

            Console.ReadLine();
        }
    }
}

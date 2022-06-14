using System;

namespace proj7Aula2{
    class Program{
        static void Main(string[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            double diferenca = a * b - c * d;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}

using System;

namespace proj11Aula2{
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n);
            Console.WriteLine(n /100 + " notas(s) de R$ 100,00");

            n = n % 100;
            Console.WriteLine(n / 50 + " notas(s) de R$ 50,00");

            n = n % 50;
            Console.WriteLine(n / 20 + " notas(s) de R$ 20,00");

            n = n % 20;
            Console.WriteLine(n / 10 + " notas(s) de R$ 10,00");

            n = n % 10;
            Console.WriteLine(n / 5 + " notas(s) de R$ 5,00");

            n = n % 5;
            Console.WriteLine(n / 2 + " notas(s) de R$ 2,00");

            n = n % 2;
            Console.WriteLine(n + " notas(s) de R$ 1,00");
        }
    }
}

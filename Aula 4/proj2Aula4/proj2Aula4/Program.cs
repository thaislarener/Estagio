using System;

namespace proj2Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x < y) {
                int aux = x;
                x = y;
                y = aux;
            }

            for (int i = y + 1; i < x; i++)
                if ((i % 2) != 0)
                    soma += i;
            Console.WriteLine("A soma do ímpares é " + soma);
        }
    }
}

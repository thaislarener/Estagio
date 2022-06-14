using System;

namespace proj12Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            int x = int.Parse(Console.ReadLine());

            do{
                z = int.Parse(Console.ReadLine());
            } while (z <= x);

            int soma = x;
            int vezes = 1;
            while(soma <= z){
                x++;
                vezes++;
                soma += x;
            }
            Console.WriteLine(vezes);
        }
    }
}

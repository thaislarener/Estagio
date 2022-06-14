using System;

namespace proj7Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anterior;
            int maior, pos;
            int i;

            anterior = int.Parse(Console.ReadLine());
            maior = anterior;
            pos = i = 1;
            do{
                anterior = int.Parse(Console.ReadLine());
                i++;
                if (anterior > maior){
                    maior = anterior;
                    pos = i;
                }
            } while (i <= 20);
            Console.WriteLine("Maior número " + maior);
            Console.WriteLine("Posição " + pos);
        }
    }
}

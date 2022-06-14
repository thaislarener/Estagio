using System;

namespace proj9Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

                if (x < y){
                    int aux = x;
                    x = y;
                    y = aux;
                }

                for (int j = y + 1; j < x; j++)
                    if ((j % 2) != 0)
                        soma += j;
                Console.WriteLine("A soma do ímpares é " + soma);
                soma = 0;
            }
        }
    }
}

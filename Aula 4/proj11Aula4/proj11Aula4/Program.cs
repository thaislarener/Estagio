using System;
using System.Linq;

namespace proj11Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            string[] vetor = Console.ReadLine().Split(' ');
            int ini = int.Parse(vetor[0]);
            int fim = int.Parse(vetor.Last());

            for(int i = 0; i < fim; i++)
                soma += (ini + i); 
            Console.WriteLine(soma);
        }
    }
}

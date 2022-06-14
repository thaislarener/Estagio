using System;

namespace proj3Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());
            int[,] A = new int[tamanho, tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanho; j++)
                    A[i, j] = int.Parse(s[j]);
            }

            int maior = A[0,0];
            for (int i = 0; i < tamanho; i++){
                for (int i2 = 0; i2 < tamanho; i2++)
                    if (A[i, i2] > maior)
                        maior = A[i, i2];
                Console.WriteLine(maior);
                maior = A[i+1,0];
            }
        }
    }
}

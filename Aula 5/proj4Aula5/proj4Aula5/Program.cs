using System;

namespace proj4Aula5
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

            int soma = 0;
            for (int i = 0; i < tamanho; i++){
                for (int j = 0; j < tamanho; j++)
                {
                    if (j > i)
                        soma +=(int) A[i, j];

                }
            }
            Console.WriteLine(soma);
        }
    }
}

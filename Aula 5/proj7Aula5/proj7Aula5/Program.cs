using System;

namespace proj7Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());

            int[,] A = new int [linhas, colunas];
            //MATRIZ A
            for (int i = 0; i < linhas; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                    A[i, j] = int.Parse(s[j]);
            }

            int fila = int.Parse(Console.ReadLine());
            fila = fila - 1;
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++)
                {
                    if(i == fila & j == (colunas-1))
                        Console.Write(A[fila, 0] + " ");
                    else if(i == fila)
                        Console.Write(A[i, j+1] + " ");
                    else
                        Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

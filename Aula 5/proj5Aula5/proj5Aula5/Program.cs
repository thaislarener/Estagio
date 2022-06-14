using System;

namespace proj5Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s1[0]);
            int colunas = int.Parse(s1[1]);
            int[,] A = new int[linhas, colunas];
            int[,] B = new int[linhas, colunas];
            int[,] C = new int[linhas, colunas];

            //MATRIZ A
            for (int i = 0; i < linhas; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                    A[i, j] = int.Parse(s[j]);
            }
            //MATRIZ B
            for (int i = 0; i < linhas; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                    B[i, j] = int.Parse(s[j]);
            }
            //MATRIZ C
            for (int i = 0; i < linhas; i++){
                for (int j = 0; j < colunas; j++){
                    C[i, j] = (int)A[i, j] + B[i, j];

                }
            }

            for (int i = 0; i < linhas; i++)
            {
                for (int i2 = 0; i2 < colunas; i2++)
                    Console.Write(C[i, i2] + " ");
                Console.WriteLine();
            }
                    
        }
    }
}

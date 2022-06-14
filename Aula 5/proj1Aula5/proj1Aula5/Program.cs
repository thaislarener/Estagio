using System;

namespace proj1Aula5
{
    class Program
    {
        static void Main(string[] args){
            
            string[] s1 = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s1[0]);
            int colunas = int.Parse(s1[1]);
            int [,]A = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                    A[i, j] = int.Parse(s[j]);
            }
            
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < linhas; i++)
            {
                for (int i2 = 0; i2 < colunas; i2++)
                {
                    if (A[i, i2] < 0)
                        Console.WriteLine(A[i, i2]);

                }
            }
        }
    }
}
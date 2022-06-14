using System;
using System.Globalization;

namespace proj6Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = int.Parse(Console.ReadLine());
            double[,] A = new double[tam, tam];

            //MATRIZ A
            for (int i = 0; i < tam; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < tam; j++)
                    A[i, j] = int.Parse(s[j]);
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            //SOMA POSITIVOS
            double soma = 0.0;
            for (int i = 0; i < tam; i++){
                for (int j = 0; j < tam; j++)
                {
                    if(A[i,j] > 0.0)
                        soma += (double) A[i, j];
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            //LINHA ESCOLHIDA
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < tam; i++)
                Console.Write(A[linha, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            Console.WriteLine();

            //COLUNA ESCOLHIDA
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < tam; i++)
                Console.Write(A[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            Console.WriteLine();

            //DIAGONAL PRINCIPAL
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                    if(i == j)
                        Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //MATRIZ ALTERADA
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < tam; i++){
                for (int j = 0; j < tam; j++)
                {
                    if (A[i, j] < 0.0)
                        A[i, j] = Math.Pow(A[i, j], 2);
                    Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Globalization;

namespace proj6Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            double media = 0.0;
            
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++){
                string[] vetor = Console.ReadLine().Split(' ');
                n1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                n1 = n2 = n3 = 0;
            }
        }
    }
}

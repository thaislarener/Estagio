using System;
using System.Globalization;

namespace proj8Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantia;
            double total = 0.0;
            double coelhos=0, ratos=0, sapos=0;
            char tipo;

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++){
                string[] vetor = Console.ReadLine().Split(' ');
                quantia = int.Parse(vetor[0]);
                tipo = char.Parse(vetor[1]);

                total += quantia;
                if(tipo == 'c')
                    coelhos += quantia;
                else if (tipo == 'r')
                    ratos += quantia;
                else if (tipo == 's')
                    sapos += quantia;
            }

            double porc = (coelhos / total) * 100;
            double porr = (ratos / total) * 100;
            double pors = (sapos / total) * 100;
            Console.WriteLine("Total: "+ total +" cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porc.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual de ratos: " + porr.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual de sapos: " + pors.ToString("F2", CultureInfo.InvariantCulture) + "%");
        }
    }
}

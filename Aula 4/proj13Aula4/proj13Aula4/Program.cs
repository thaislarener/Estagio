using System;
using System.Globalization;

namespace proj13Aula4
{
    class Program
    {
        static void Main(string[] args){
            int pa, pb, anos=0;
            double g1, g2;
            double cresc1, cresc2;

            int t = int.Parse(Console.ReadLine());

            for(int i =0; i < t; i++){
                string[] vetor = Console.ReadLine().Split(' ');
                pa = int.Parse(vetor[0]);
                pb = int.Parse(vetor[1]);
                g1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                g2 = double.Parse(vetor[3], CultureInfo.InvariantCulture);

                while(pa <= pb & anos < 115){
                    cresc1 = pa + ((pa* g1) / 100);
                    pa = (int)cresc1;
                    
                    cresc2 = pb + ((pb * g2) / 100);
                    pb = (int)cresc2;
                    anos++;
                }

                if(anos > 100)
                    Console.WriteLine("Mais de 1 seculo.");
                else
                    Console.WriteLine(anos + " anos.");
                anos = 0;

            }
            
        }
    }
}

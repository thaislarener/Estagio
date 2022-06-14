using System;
using System.Globalization;

namespace proj12Aula2{
    class Program{
        static void Main(string[] args){
            string[] vetor1 = Console.ReadLine().Split(' ');
            string[] vetor2 = Console.ReadLine().Split(' ');

            string nome1 = vetor1[0];
            int idade1 = int.Parse(vetor1[1]);
            string nome2 = vetor2[0];
            int idade2 = int.Parse(vetor2[1]);

            double idadeMedia = (double)(idade1 + idade2) / 2;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

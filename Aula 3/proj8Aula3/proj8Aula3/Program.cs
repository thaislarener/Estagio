using System;

namespace proj8Aula3{
    class Program{
        static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vetor[0]);
            int n2 = int.Parse(vetor[1]);
            int n3 = int.Parse(vetor[2]);

            int menor = n1;

            if (n2 < menor)
                menor = n2;
            if (n3 < menor)
                menor = n3;

            Console.WriteLine("MENOR = " + menor);
        }
    }
}

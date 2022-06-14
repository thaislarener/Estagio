using System;

namespace proj11Aula3{
    class Program{
        static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);
            int d = int.Parse(vetor[3]);

            if (b > c & d > a)
                if (c + d > a + b & c > 0 & d > 0)
                    if (a % 2 == 0)
                        Console.WriteLine("Valores aceitos");
                    else
                        Console.WriteLine("Valores não aceitos");
                else
                    Console.WriteLine("Valores não aceitos");
            else
                Console.WriteLine("Valores não aceitos");
        }
    }
}

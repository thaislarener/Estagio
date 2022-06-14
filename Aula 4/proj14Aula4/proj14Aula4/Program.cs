using System;

namespace proj14Aula4
{
    class Program{
        static void Main(string[] args){
            int x;
            string[] vetor;
            int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
             vetor = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++){
                x = int.Parse(vetor[i]);
                if (x < 0)
                    Console.WriteLine(x);
            }
        }
    }
}

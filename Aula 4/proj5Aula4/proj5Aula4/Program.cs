using System;

namespace proj5Aula4
{
    class Program
    {
        static void Main(string[] args){
            int x = 0;
            int dentro = 0;
            int fora = 0;

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++){
                x = int.Parse(Console.ReadLine());
                if (x >= 10 & x <= 20)
                    dentro++;
                else
                    fora++;
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}

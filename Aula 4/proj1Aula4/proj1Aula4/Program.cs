using System;

namespace proj1Aula4
{
    class Program
    {
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i + " X " + n + " = " + (i*n));
            }
        }
    }
}

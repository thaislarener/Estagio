using System;

namespace proj10Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for(int i = 1; i <= y; ) {
                for (int j = 0; j < x; j++){
                    Console.Write(i + " ");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}

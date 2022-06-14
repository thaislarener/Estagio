using System;
using System.Globalization;

namespace proj18Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ex = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (n1 + (n2 * 2) + (n3 * 3) + ex) / 7;

            if(media >= 9.0)
                Console.WriteLine("A");
            else if (media >= 7.5 & media < 9.0)
                Console.WriteLine("B");
            else if (media >= 6.0 & media < 7.5)
                Console.WriteLine("C");
            else if (media < 6.0)
                Console.WriteLine("D");
        }
    }
}

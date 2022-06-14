using System;
using System.Globalization;

namespace proj7Aula3{
    class Program{
        static void Main(string[] args){
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + (n1 + n2).ToString("F1", CultureInfo.InvariantCulture));

            if ((n1 + n2) < 60.00)
                Console.WriteLine("REPROVADO");
        }
    }
}

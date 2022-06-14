using System;
using System.Globalization;

namespace proj6Aula2{
    class Program{
        static void Main(string[] args){
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.00;

            Console.WriteLine("MÉDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace proj5Aula2{
    class Program{
        static void Main(string[] args){
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A * 3.5 + B * 7.5) / 11.00;

            Console.WriteLine("MÉDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}

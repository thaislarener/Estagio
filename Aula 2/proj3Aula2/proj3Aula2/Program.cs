using System;
using System.Globalization;

namespace proj3Aula2{
    class Program{
        static void Main(string[] args){
            double base1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = base1 * altura;
            double perimetro = (2 * base1) + (2 * altura);
            double diagonal = Math.Sqrt(Math.Pow(base1, 2) + Math.Pow(altura, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

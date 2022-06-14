using System;
using System.Globalization;

namespace proj9Aula2{
    class Program{
        static void Main(string[] args){
            int horas = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double litros = (double)(horas * velocidade) / 12.00;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace proj2Aula2{
    class Program{
        static void Main(string[] args){
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            double area = largura * comprimento;
            double preco = area * valorMetro;
            
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

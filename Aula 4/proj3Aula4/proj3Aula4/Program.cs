using System;
using System.Globalization;

namespace proj3Aula4
{
    class Program
    {
        static void Main(string[] args){
            char stg;
            double fah;

            do{
                Console.WriteLine("Digite a temperatura em celsius: ");
                double temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                fah = (temperatura * 1.8) + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + fah.ToString("F1", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja repetir? (s/n)");
                stg = char.Parse(Console.ReadLine());
            } while (stg == 's');
            
        }
    }
}

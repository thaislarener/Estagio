using System;
using System.Globalization;

namespace proj5Aula3{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Kilos de morango:");
            double morango = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Kilos de maça:");
            double maca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double kilos = morango + maca;
            if (morango >= 5.0)
                morango *= 2.20;
            else
                morango *= 2.50;

            if (maca >= 5.0)
                maca *= 1.50;
            else
                maca *= 1.80;

            double valor = morango + maca;

            if (kilos > 8.0 | valor > 25)
                valor = valor - (valor * 0.10);

            Console.WriteLine("O valor a ser pago é: R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

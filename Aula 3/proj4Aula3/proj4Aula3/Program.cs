using System;
using System.Globalization;

namespace proj4Aula3{
    class Program{
        static void Main(string[] args){
            double valor = 0.0;
            double desconto = 0.0;

            double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char tipo = char.Parse(Console.ReadLine());

            if (tipo.Equals('G')){
                valor = litros * 7.30;

                if (litros < 20)
                    desconto = valor * 0.04;
                else
                    desconto = valor * 0.06;              
            }
            else if (tipo.Equals('A')){
                valor = litros * 4.90;
                if (litros < 20)
                    desconto = valor * 0.03;                
                else
                    desconto = valor * 0.05;
            }

            Console.WriteLine(tipo + ": o valor a ser pago é " + (valor - desconto).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

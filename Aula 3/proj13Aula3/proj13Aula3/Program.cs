using System;
using System.Globalization;

namespace proj13Aula3{
    class Program{
        static void Main(string[] args){
            double reajuste = 0.00;
            int ajuste = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario >= 0.00 && salario <= 400.00){
                reajuste = salario * 0.15;
                ajuste = 15;
            }
            else if (salario >= 400.01 && salario <= 800.00){
                reajuste = salario * 0.12;
                ajuste = 12;
            }
            else if (salario >= 800.01 && salario <= 1200.00){
                reajuste = salario * 0.10;
                ajuste = 10;
            }
            else if (salario >= 1200.01 && salario <= 2000.00){
                reajuste = salario * 0.07;
                ajuste = 7;
            }
            else if (salario > 2000.00){
                reajuste = salario * 0.04;
                ajuste = 4;
            }

            salario += reajuste;
            Console.WriteLine("Novo salário: " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + ajuste + "%");
        }
    }
}

using System;
using System.Globalization;

namespace proj8Aula2{
    class Program{
        static void Main(string[] args){
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = (double)horas * valor;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

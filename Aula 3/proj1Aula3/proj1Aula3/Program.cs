using System;
using System.Globalization;

namespace proj1Aula3{
    class Program{
        static void Main(string[] args){
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (nota >= 6.0)
                Console.WriteLine("O aluno está aprovado!");
            else if (nota < 6.0)
                Console.WriteLine("O aluno está reprovado!");
            
        }
    }
}

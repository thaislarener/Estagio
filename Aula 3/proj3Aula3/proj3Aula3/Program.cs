using System;

namespace proj3Aula3{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Informe a idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("É estudante?");
            string estudante = Console.ReadLine();

            if(idade >= 65 | String.Equals(estudante, "sim"))
                Console.WriteLine("O valor do ingresso é R$15,00");
            else
                Console.WriteLine("O valor do ingresso é R$30,00");
        }
    }
}

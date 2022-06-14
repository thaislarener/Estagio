using System;

namespace proj2Aula3{
    class Program{
        static void Main(string[] args){
            int idade = int.Parse(Console.ReadLine());
            string socio = Console.ReadLine();

            if(idade >= 65 | String.Equals(socio, "sim") )
                Console.WriteLine("A pessoa possui desconto!");
            else
                Console.WriteLine("A pessoa não possui desconto!");
        }
    }
}

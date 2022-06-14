using System;

namespace proj6Aula3{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite o código de usuario:");
            string codigo = Console.ReadLine();

            if (String.Equals(codigo, "1234")){
                Console.WriteLine("Digite a senha:");
                string senha = Console.ReadLine();
                if(string.Equals(senha,"9999"))
                    Console.WriteLine("Acesso Permitido");
                else
                    Console.WriteLine("Senha incorreta");
            }
            else
                Console.WriteLine("Usuário inválido!");
        }
    }
}

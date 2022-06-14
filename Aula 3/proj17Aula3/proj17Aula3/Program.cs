using System;

namespace proj17Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo;

            int codigo = int.Parse(Console.ReadLine());
            int anoNasc = int.Parse(Console.ReadLine());
            int anoEnt = int.Parse(Console.ReadLine());

            idade = 2022 - anoNasc;
            tempo = 2022 - anoEnt;

            Console.WriteLine("Idade: " + idade + ", Tempo de serviço: " + tempo);
            if (idade >= 65 | tempo >= 30 | (idade >= 60 & tempo >= 25))
                Console.WriteLine("Requer aposentadoria");
            else
                Console.WriteLine("Não requer");
        }
    }
}

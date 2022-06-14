using System;

namespace proj12Aula3{
    class Program{
        static void Main(string[] args){
            int total = 0;
            int inicio = int.Parse(Console.ReadLine());
            int fim = int.Parse(Console.ReadLine());

            if (fim < inicio)
                total = (24 - inicio) + fim;

            else if (fim > inicio)
                total = fim - inicio;

            else if (inicio == fim)
                total = 24;
            Console.WriteLine("O JOGO DUROU " + total + " HORA (S)");
        }
    }
}

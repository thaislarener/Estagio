using System;

namespace proj9Aula3{
    class Program{
        static void Main(string[] args){
            int minutos = int.Parse(Console.ReadLine());

            if(minutos <= 100)
                Console.WriteLine("Valor a pagar: R$ 50.00");
            else{
                minutos -= 100;
                int valor = 50 + (2 * minutos);
                Console.WriteLine("Valor a pagar: R$ " + valor + ".00");
            }
        }
    }
}

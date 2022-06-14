using System;

namespace proj10Aula2{
    class Program{
        static void Main(string[] args){
            int segundos = int.Parse(Console.ReadLine());
           
            int minutos = (segundos % 3600) / 60;
            int horas = segundos / 3600;
            segundos %= 60;

            Console.Write(horas + ":" + minutos + ":" + segundos);        
        }
    }
}

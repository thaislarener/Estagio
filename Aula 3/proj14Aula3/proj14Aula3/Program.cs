using System;

namespace proj14Aula3{
    class Program{
        static void Main(string[] args){
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (string.Equals(palavra1,"vertebrado")){
                if (string.Equals(palavra2, "ave")){
                    if (string.Equals(palavra3, "carnivoro"))
                        Console.WriteLine("aguia");
                    else if (string.Equals(palavra3, "onivoro"))
                        Console.WriteLine("pomba");
                }
                else if (string.Equals(palavra2, "mamifero")){
                    if (string.Equals(palavra3, "onivoro"))
                        Console.WriteLine("homem");
                    else if (string.Equals(palavra3, "herbivoro"))
                        Console.WriteLine("vaca");
                }
            }
            else if (string.Equals(palavra2, "invertebrado")){
                if (string.Equals(palavra2, "inseto"))
                {
                    if (string.Equals(palavra3, "hematofago"))
                        Console.WriteLine("pulga");
                    else if (string.Equals(palavra3, "herbivoro"))
                        Console.WriteLine("lagarta");
                }
                else if (string.Equals(palavra2, "anelideo"))
                {
                    if (string.Equals(palavra3, "hematofago"))
                        Console.WriteLine("sanguessuga");
                    else if (string.Equals(palavra3, "onivoro"))
                        Console.WriteLine("minhoca");
                }
            }
        }
    }
}

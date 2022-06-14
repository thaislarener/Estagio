﻿using System;
using System.Globalization;

namespace proj13Aula2{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu ultimo nome, idade e altura (mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
                        
        }
    }
}

using System;
using System.Globalization;

//Identação automática Ctrl + K + D
namespace PrimeiroProjeto{
    class Program{
        static void Main(string[] args){
            //Console.Write("Bem Vindo!");//Sem quebra de linha
            //Console.WriteLine("Olá mundo!");//Com quebra de linha

            //Print de variável do tipo double
            /*double x = 10.35784;
            
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));*/

            //Print de variável com concatenação
            /*int a = 14 + 21;
            int b = 2;
            
            Console.WriteLine("O valor de X é " + x.ToString("F2"));
            Console.WriteLine("O valor de A é " + a + ".");
            Console.WriteLine("O valor de A + B é " + (a + b) + ".");*/

            /*int y = 32;
            string z = "Maria";
            char w = 'F';
            
            Console.WriteLine(z);
            Console.WriteLine(w);
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w + ".");
            Console.ReadLine();*/

            /*int x1;
            double y1;
            
            x1 = 5;
            y1 = 2 * x1;
            
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            int valor = ((2 + 33 + 3) * 2) + (1400 - 100) * 3;
            Console.WriteLine(valor);*/

            /*double b, B, h, area;
            
            b = 6.0;
            B = 8.0;
            h = 5.0;
            
            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);*/

            /*int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double) a / b;
            Console.WriteLine(resultado);*/

            /*int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());

            int soma = A + B;

            Console.WriteLine("SOMA = {0}", soma);*/

            /*int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());

            int prod = A * B;

            Console.WriteLine("PROD = {0}", prod);*/

            /*double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(qtdQuartos);*/


            /*string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];*/

            //string[] vet = Console.ReadLine().Split(' ');
            //Console.WriteLine(vet[0] + "," + vet[1] + "," + vet[2]);


            /*string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Nome: " + nome + ", Sexo: " + sexo + ", Idade: " + idade + ", Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture);
            */
            //MATRIZ
            int[ , ] A;

            string[] s1 = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s1[0]);
            int colunas = int.Parse(s1[1]);
            A = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                    A[i, j] = int.Parse(s[j]);
            }
        }
    }
}

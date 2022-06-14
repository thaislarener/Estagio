using System;

namespace proj15Aula3{
    class Program{
        static void Main(string[] args){
            int par = 0, impar = 0;
            int pos = 0, neg = 0;

            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());
            int val3 = int.Parse(Console.ReadLine());
            int val4 = int.Parse(Console.ReadLine());
            int val5 = int.Parse(Console.ReadLine());

            //valor 1
            if (val1 > 0)
                pos++;
            if (val1 < 0)
                neg++;
            if (val1 % 2 == 0)
                par++;
            else
                impar++;
            //valor2
            if (val2 > 0)
                pos++;
            if (val2 < 0)
                neg++;
            if (val2 % 2 == 0)
                par++;
            else
                impar++;
            //valor3
            if (val3 > 0)
                pos++;
            if (val3 < 0)
                neg++;
            if (val3 % 2 == 0)
                par++;
            else
                impar++;
            //valor4
            if (val4 > 0)
                pos++;
            if (val4 < 0)
                neg++;
            if (val4 % 2 == 0)
                par++;
            else
                impar++;
            //valor5
            if (val5 > 0)
                pos++;
            if (val5 < 0)
                neg++;
            if (val5 % 2 == 0)
                par++;
            else
                impar++;

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
        }
    }
}

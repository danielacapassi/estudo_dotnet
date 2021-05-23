using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           // Array de inteiros com 5 posições!
             Console.WriteLine("-------Array de inteiros com 5 posições!----------");
           int [] age = new int[5];

           age[0] = 15;
           age[1] = 28;
           age[2] = 35;
           age[3] = 50;
           age[4] =28;

           Console.WriteLine(age[4]);

           Console.WriteLine("-------com FOR e Length-----------");
           // com FOR e Length
         int[] idades = null;
         idades = new int[5];

           idades[0] = 15;
           idades[1] = 28;
           idades[2] = 35;
           idades[3] = 50;
           idades[4] =28;

           
           int acumulador = 0;

           for (int indice = 0; indice < idades.Length; indice++ )
           {
               int idade = idades[indice];

               Console.WriteLine($"Acessando o array idades no indice {indice}");
               Console.WriteLine($"Valor de  idades  [{indice}] = {idade}");

               acumulador  += idade;
           }
            
           int media = acumulador / idades.Length;
           Console.WriteLine($"Média de idades = {media}");



           

        }


    }
}

using System;

namespace dia1aula6
{
    class Program
    {
        static void Main(string[] args)
        {
                // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********

            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                 // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            for(int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                        break;

                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
              
               Console.WriteLine("-----------------------------");
               // for encadeado que imprima a tabuada de cada número
         
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = "+ multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
        }
                Console.WriteLine("--------matriz triangular-------------");
                
                 //break imprimindo uma matriz triangular
                for (int linhax = 0; linhax < 10; linhax++)
        {
                for(int colunay = 0; colunay <= linhax; colunay++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                Console.WriteLine("-----------------------------");
               //imprimir os fatoriais de 1 a 10! (O fatorial de um número n é n * n-1 * n-2 ... até n = 1.O fatorial de 4! = 1 x 2 x 3 x 4 = 24)

                int fatorial = 1;
                for (int o = 1; o < 11; o++)
                {
                    fatorial *= o;
                    Console.WriteLine("Fatorial de " + o + " = " + fatorial);
        }

          
                Console.WriteLine("-----------------------------");
                //imprimir todos os múltiplos de 3, entre 1 e 100.

                for(int i = 3 ; i < 100 ; i+=3)
                {
                  Console.WriteLine(i);
                }
                //OU
                 Console.WriteLine("---------------OU------------");

                for(int e =0 ; e <100 ; e++)
                {
                    if(e % 3 == 0){
                        Console.WriteLine(e);
                    }
                }

            Console.ReadLine();
        }
    }
}

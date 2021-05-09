using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {

        //ARITMÉTICOS:
          int x = 5;
          int y = 3;
          Console.WriteLine(x + y); 
          Console.WriteLine(x - y); 
          Console.WriteLine(x * y); 
          Console.WriteLine(x / y); 
          Console.WriteLine(x % y); 
          
        //ATRIBUIÇÃO:
        // =	x = 5	x = 5	
        int teste = 5;
      Console.WriteLine(teste); 
        // +=	x += 3	x = x + 3	
         int testeSom = 5;
         testeSom += 3;
         Console.WriteLine(testeSom); 
        // -=	x -= 3	x = x - 3	
        int testeSub = 5;
         testeSub -= 3;
         Console.WriteLine(testeSub); 
        // *=	x *= 3	x = x * 3	
        int testeMul = 5;
         testeMul *= 3;
         Console.WriteLine(testeMul); 
        // /=	x /= 3	x = x / 3
         int testeDiv = 5;
         testeDiv /= 3;
         Console.WriteLine(testeDiv); 
        // %=	x %= 3	x = x % 3	
         int testeMod = 5;
         testeMod %= 3;
         Console.WriteLine(testeMod); 

         //COMPARAÇÃO:

          int a = 5;
          int b = 3;
          Console.WriteLine(a == b); //igual a 
          Console.WriteLine(a != b); //não igual
          Console.WriteLine(a > b);  //maior
          Console.WriteLine(a < b); // menor
          Console.WriteLine(a >= b);//  maior igual
          Console.WriteLine(a <= b);// menor igual


     

       // LÓGICOS:
         int comparar = 5;
         Console.WriteLine(comparar > 3 && comparar < 10); // e
         Console.WriteLine(comparar > 3 || comparar < 4); // ou
         Console.WriteLine(!(comparar > 3 && comparar < 10)); // inverte (não igual)
        }
    }
}

using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
        //Math.Max :
        //O método pode ser usado para encontrar o maior valor de x e y :Math.Max(x,y)
        Console.WriteLine(Math.Max(5, 10));  
        //Math.Min :
        //O método pode ser usado para encontrar o menor valor de x e y :Math.Min(x,y)
        Console.WriteLine(Math.Min(5, 10));
        //Math.Sqrt :
        //O método retorna a raiz quadrada de x :Math.Sqrt(x)
        Console.WriteLine(Math.Sqrt(64));  
        //Math.Abs :
        //O método retorna o valor absoluto (positivo) de x :Math.Abs(x)
        Console.WriteLine(Math.Abs(-4.7));
        //Math.Round :
        //Math.Round() arredonda um número para o número inteiro mais próximo:
        Console.WriteLine(Math.Round(9.99));
        }
    }
}

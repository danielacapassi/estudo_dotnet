//Quando você atribui um valor de um tipo de dados a outro tipo.

//Explicit Casting (manualmente) - conversão de um tipo maior para um tipo de tamanho menor
//double-> float-> long-> int->char

using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
      int myInt = 80;
      double myDouble = 5.50;
      bool myBool = false;

      Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
      Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
      Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
      Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
        }
    }
}

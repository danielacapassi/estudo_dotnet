using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // numeros pares
         for (int i = 0; i <= 10; i = i + 2)
      {
        Console.WriteLine(i);
        }
      
       Console.WriteLine ("-------------------------");

       // numeros até 4
        for (int e = 0; e < 5; e++) 
{
  Console.WriteLine(e);
}

 Console.WriteLine ("-------------------------");

// foreach
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string a in cars) 
{
  Console.WriteLine(a);
}

    }
}
}
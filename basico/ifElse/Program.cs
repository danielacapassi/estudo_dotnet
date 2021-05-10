using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
      //
      int x = 20;
      int y = 18;
      if (x > y)
      {
        Console.WriteLine("x é maior que  y");
      }
      //
       if (20 > 18) 
      {
        Console.WriteLine("20 é maior que 18");
      }  
      
      //
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Bom dia.");
      } 
      else 
      {
        Console.WriteLine("Boa noite.");
      }
      
      //
      int periodoDia = 22;
      if (periodoDia < 10) 
      {
        Console.WriteLine("Bom dia.");
      } 
      else if (periodoDia < 20) 
      {
        Console.WriteLine("Boa tarde.");
      } 
      else 
      {
        Console.WriteLine("Boa noite.");
      }
      //operador ternário (if...else abreviado): variable = (condition) ? expressionTrue :  expressionFalse;
      int periodoDiaResumido = 20;
      string result = (periodoDiaResumido < 18) ? "Bom dia." : "Boa tarde.";
      Console.WriteLine(result);
        }
    }
}

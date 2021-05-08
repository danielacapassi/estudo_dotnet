using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            
      Console.WriteLine("Digite um nome:");

      string userName = Console.ReadLine();

      Console.WriteLine("Digite um número:");
      
      string userNumber = Console.ReadLine();

      Console.WriteLine("O nome digitado foi: " + userName + "  e o número digitado foi: " + userNumber);
        }
    }
}

using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //String Length
         string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         Console.WriteLine("A quantidade de letras é de: " + txt.Length);

        //ToUpper
         string maiuscula = "Hello World";
         Console.WriteLine(maiuscula.ToUpper());   // Outputs "HELLO WORLD"

        //ToLower
          string minuscula = "Hello World";
          Console.WriteLine(minuscula.ToLower());   // Outputs "hello world"
       
        //Concatenation: juntar duas strings
         string firstName = "John ";
         string lastName = "Doe";
         string name = firstName + lastName;
         Console.WriteLine(name);
       
         string firstName2 = "John ";
         string lastName2 = "Doe";
         string name2 = string.Concat(firstName2, lastName2);
         Console.WriteLine(name);

         // Interpolation
          string firstName3 = "John";
          string lastName3 = "Doe";
          string name3 = $"Meu nome completo é : {firstName} {lastName}";
          Console.WriteLine(name3);

          // Access
          string myString = "Hello";
          Console.WriteLine(myString[0]);
          Console.WriteLine(myString[1]);  

          //  IndexOf()  : encontrar a posição do índice de um caractere específico em uma string
          string myString3 = "Hello";
          Console.WriteLine(myString3.IndexOf("e"));

          //Substring() : extrai os caracteres de uma string, começando da posição / índice do caractere especificado, e retorna uma nova string
        
          string nome = "John Doe";

          // Location of the letter D
          int charPos = nome.IndexOf("D");

          // Get last name
          string sobrenome = nome.Substring(charPos);

          // Print the result
          Console.WriteLine(sobrenome);
       
       
        }
    }
}

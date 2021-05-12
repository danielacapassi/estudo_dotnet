using System;

namespace arraysUso
{
    class Program
    {
        static void Main(string[] args)
        {

       // alterando um valor especifico
       string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        cars[0] = "Opel";
        Console.WriteLine(cars[0]);

        Console.WriteLine("------------------------------");

        //length: quantos elementos o array possui
        string[] cars1 = {"Volvo", "BMW", "Ford", "Mazda"};
        Console.WriteLine(cars1.Length);

        Console.WriteLine("------------------------------");

        //array com loop for loopstring[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        for (int i = 0; i < cars.Length; i++) 
        {
        Console.WriteLine(cars[i]);
        }
      
        Console.WriteLine("------------------------------");

        string[] cars2 = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars2) 
        {
        Console.WriteLine(i);
        }

        Console.WriteLine("------------------------------");

           // Sort a string
        string[] cars3 = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(cars3);
        foreach (string e in cars3)
        {
        Console.WriteLine(e);
        }

        Console.WriteLine("------------------------------");

        // Sort an int
        int[] myNumbers = {5, 1, 8, 9};
        Array.Sort(myNumbers);
        foreach (int o in myNumbers)
        {
        Console.WriteLine(o);
        }

        }
    }
}

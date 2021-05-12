using System;

namespace breakUso
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
        {
        if (i == 4) 
        {
            break;
        }
        Console.WriteLine(i);
        }

        Console.WriteLine("-------------------");

       // CONTINUE
        for (int e = 0; e < 10; e++) 
        {
        if ( e == 4) 
        {
            continue;
        }
        Console.WriteLine(e);
        }
        Console.WriteLine("-------------------");

        //Break and Continue in While Loop
        int a = 0;
        while (a < 10) 
        {
        Console.WriteLine(a);
        a++;
        if (a == 4) 
        {
            break;
        }
        }
        Console.WriteLine("-------------------");
       
        int o = 0;
        while (o < 10) 
        {
        if (o == 4) 
        {
            o++;
            continue;
        }
        Console.WriteLine(o);
        o++;
        }
                        }
                    }
                }

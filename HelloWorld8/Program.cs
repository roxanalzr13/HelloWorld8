using System;

namespace HelloWorld8
{
    class Program
    {
        static void Main(string[] args)
        {
          //daca a divizibil cu b, atunci restul este 0;
          //ALTFEL ESTE INDIVIZIBIL
            Console.WriteLine("a");
            int a = 10;
            Console.WriteLine("b");
            int b = 5;
            if(a%b==0)
            {
                Console.WriteLine("divizibil");

            }
            else
            { 
                Console.WriteLine("INDIVIZIBIL");

            }

        }
    }
}


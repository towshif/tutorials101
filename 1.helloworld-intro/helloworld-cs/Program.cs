using System;

namespace helloworld_cs
{
    class Program
    {
    	// main function -> entrypoint
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Add 5 + 2 = " + addme (5,2));
            Console.WriteLine("mult 5 * 2 = " + multme (5,2));
            Console.WriteLine("divide 5 / 2 = " + divide (5,2));
        }

        // Function to add 2 numbers
        static int addme ( int a, int b) {
        	return a+b;
        }

        // Function to add 2 numbers
        static int multme ( int a, int b) {
        	return a*b;
        }


        // Function to add 2 numbers
        static int divideme ( int a, int b) {
        	return a/b;
        }
    }
}

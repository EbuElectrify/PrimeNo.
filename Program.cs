using System;
//Lab 3; write a c# program to check prime number
//input 17
//output: prime number
//input 57
//output:not prime number
namespace PrimeNo
{
    class Program    {
                static void Main(string[] args)    {
            int first = 17;
             Console.WriteLine("First number is 17");
            //check divisibility
            if (first % 2 != 0 && first % 3 != 0 && first % 5 != 0 && first % 7 != 0)        {
                Console.WriteLine("This is a prime number");
            }
              else       {
                Console.WriteLine("This is Not a Prime Number");
            }
            int second = 57;
              Console.WriteLine("Second number is 57");
            //check divisibility
            if (second % 2 != 0 && second % 3 != 0 && second % 5 != 0 && second % 7 != 0)        {
                Console.WriteLine("This is a prime number");
            }
              else       {
                Console.WriteLine("This is Not a Prime Number");
            }
        }
    }
}

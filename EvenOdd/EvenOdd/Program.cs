/*
 * C# Program to Check whether the Entered Number is Even or Odd
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we establish a var, and promp the user to enter an input
            int i;
            Console.Write("Enter a Number : ");
            //Here we take the input, which is entered as a string, and parse it, then asign it to our var
            i = int.Parse(Console.ReadLine());
            //We then have an if else statement where we determin if the var is
            //divisible by 2, where the result determins if it is an even or odd num
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
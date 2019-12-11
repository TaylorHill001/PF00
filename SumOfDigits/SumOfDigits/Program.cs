/*
 * C# Program to Get a Number and Display the Sum of the Digits 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //First establish your var's
            int num, sum = 0, r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            //Here we create a while loop and while it isnt set to zero
            //the loop will evaluate the sum of digits
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();

        }
    }
}
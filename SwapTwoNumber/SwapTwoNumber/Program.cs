/*
 * C# Program to Swap two Numbers
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
            //First we assign three var's. two are the numbers we will
            //be switching and the other will be a placeholder to hold
            //one of the numbers while asigning one number to the other
            int num1, num2, temp;
            //assign the first two numbers
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            //this is where temp holds the first number, then the two
            //other numbers will be switched
            temp = num1;
            num1 = num2;
            num2 = temp;
            //here we write out the numbers to show they are swapped
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
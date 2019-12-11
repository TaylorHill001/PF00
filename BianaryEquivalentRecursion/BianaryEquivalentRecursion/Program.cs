/*
 * C# Program to Print Binary Equivalent of an Integer using Recursion
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        int num;
        prog pg = new prog();
        Console.WriteLine("Enter a decimal number: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary equivalent of num is :");
        pg.binaryconversion(num);
        Console.ReadLine();
    }
}
public class prog
{
    public int binaryconversion(int num)
    {
        //If else condition statement is used to check the value of ‘num’ variable is equal to 0.
        //If the condition is true then execute the statement and return the value of 0.
        //if the condition is false then execute the else statement. Compute the modulus
        //of the value of ‘num’ variable by 2. Add the value of ‘result’ variable to 10.
        //Multiply the value of ‘result’ variable with the value of binary_conversion() function.
        int bin;
        if (num != 0)
        {
            bin = (num % 2) + 10 * binaryconversion(num / 2);
            Console.Write(bin);
            return 0;
        }
        else
        {
            return 0;
        }

    }
}

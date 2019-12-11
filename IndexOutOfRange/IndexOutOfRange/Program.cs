/*
 * C# Program to Demonstrate IndexOutOfRange Exception
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace differnce
{
    class arrayoutofindex
    {
        public void calculatedifference()
        {
            //In calculatedifference() procedure assign an value to the number[] array variable.
            //In try statement for loop is used to compute the difference between the value of ‘variable’
            //by the value of ‘number[]’ array variable.
            int difference = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            //If the array has the index value out of the range that is specified then the exception
            //is thrown. Using try and catch, an error message is displayed when the error occurs.
            try
            {
                for (int init = 1; init <= 5; init++)
                {
                    difference = difference - number[init];
                }
                Console.WriteLine("The difference of the array is:" + difference);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class classmain
    {
        static void Main(string[] args)
        {
            arrayoutofindex obj = new arrayoutofindex();
            obj.calculatedifference();
            Console.ReadLine();
        }
    }
}
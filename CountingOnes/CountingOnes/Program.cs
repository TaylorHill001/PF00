/*
 * C# Program to Count the Number of 1's in the Entered Number
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiate your counter and promp user
            int m, count = 0;
            Console.WriteLine("Enter the Limit : ");
            //use parse to convert entered input into int's
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.WriteLine("Enter the Numbers :");
            //use the foor loop to convert and count
            for (int i = 0; i < m; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int o in a)
            {
                if (o == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of 1's in the Entered Number : ");
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace CSHARP
{
    internal class ExceptionExample
    {

        static void Main(String[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("First Number:");
                a = Convert.ToInt32(Console.ReadLine());  //This Line will take the input for the int a.

                Console.WriteLine("First Number:");
                b = Convert.ToInt32(Console.ReadLine());  //This Line will take the input for the int a.

                c = a / b;
                Console.WriteLine(c);
            }
            catch (FormatException ex) {
                // Here, if you will do any small mistakes in run time then the program will throw the exception.
                Console.WriteLine("Enter only numeric data: ");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot be divided by zero!!!");  //This Exception is thrown when you will divide the number with 0     
             }
            
        }
    }
}

//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //Write a program that prints the numbers from 1 to 100
            //  and for multiples of '3' print "Fizz" instead of the number and for the multiples of '5' print "Buzz".
            
            int number;
            
            // loop for 100 times
            for(number=1; number<=100; number++){
             
                // when nunber divisiable by 3 
                if (number % 15 == 0)
                {
                    Console.WriteLine("Fizz and Buzz");
                }
                    else if(number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                   
                }
                // when nunber divisiable by 5
                else if(number % 5 == 0)
                {
                     Console.WriteLine("Buzz");
                }else
                {
                    Console.WriteLine(number);
                }
            }
            
        }
    }
}
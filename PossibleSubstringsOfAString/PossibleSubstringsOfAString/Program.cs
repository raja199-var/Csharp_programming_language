/*
 * program to find all substrings of a string using Substring() method
 * 
 * */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleSubstringsOfAString
{
    internal class Program
    {
         static void Main(string[] args)
         {
             Console.WriteLine("Enter the string: ");
             string str = Console.ReadLine();
         
            
             for(int  i =1;i<=str.Length;i++)
             {
                 for(int j = 0; j <=str.Length-i; j++)
                 {
                     string substring = str.Substring(j,i) ;
                     Console.WriteLine(substring);
                 }
             }

             Console.ReadLine();
         }
   
    }
}

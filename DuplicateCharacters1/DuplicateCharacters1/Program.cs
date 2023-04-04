using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharacters1
{
    internal class Program
    {

          static void Main(string[] args)
          {

              Console.WriteLine("Enter the string: ");
              char[] str = Console.ReadLine().ToCharArray();
            
              

              int  j,i;
              int k = 0;

              for(i = 0; i < str.Length; i++)
              {
                  for( j = 0; j < i; j++)
                  {
                      if (str[i] == str[j])
                      {
                          break;
                      }
                  }

                  if (i == j)
                  {
                      str[k++] = str[i];

                  }
              }
            char[] ans = new char[k];
            Array.Copy(str, ans, k);
            Console.WriteLine(ans);
            Console.ReadLine();
          }

       
    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int i;
             int n = 50;
             for (i = 1; i <= n; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine("Result =" + i);
                 }
             }*/
            /*int x = 0;
            for (int i = 0; i< 4; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    x = i + j;
                    if (x % 2 == 0)
                    {
                        Console.Write("X");

                    }
                    else
                    {
                        Console.Write("0");

                    }

                }
                Console.WriteLine();
            }*/
            
            int y= 0;
            for (int i = 1; i <= 7; i++)
            {
                y = i;
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(y + j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            }

        }
    }

   

          
        
    
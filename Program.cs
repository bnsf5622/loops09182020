using System;

namespace loops09182020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's Spring...!");
            for (int i = 0; i < 10; i++)
             Console.WriteLine(i + ", ");    
                {
                    Console.WriteLine(" Oh no, it's Fall...");
                    for ( int i = 10; i > 0; i--)
                    {
                        Console.WriteLine(i + ","); 
                    }
                }
            }
        }
    }
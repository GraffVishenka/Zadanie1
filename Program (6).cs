using System;
using static System.Console;
using static System.Convert;
using MyLibrary;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lib1.stpow("aloha", 5));
            Console.WriteLine(lib1.rev("arigato"));
            Console.WriteLine(lib1.remov("plmpaop","p"));
            Console.WriteLine(lib1.leng("Your personal nightmare."));
        }
    }
}

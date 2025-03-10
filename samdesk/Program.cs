
using System;
using System.Collections.Generic;

namespace SamDesk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShortDistance test = new ShortDistance();
            Console.WriteLine(string.Format("Result is {0}",test.SolveLists(new List<int>() { 4, 3, 5, 3, 9, 3 }, new List<int>() { 3, 4, 2, 1, 3, 3 })));
            Console.WriteLine("Real input date is in SamDeskTests\\input.txt");
            Console.WriteLine("Test method SolveListsFromFileTest() is in SamDeskTests\\ShortDistanceTests.cs");
        }
    }
}

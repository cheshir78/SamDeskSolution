using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace SamDesk.Tests
{
    [TestClass()]
    public class ShortDistanceTests
    {
        [TestMethod()]
        public void SolveListsTest()
        {
            var listRight = new List<int>() { 4, 3, 5, 3, 9, 3 }; 
            var listLeft = new List<int>() { 3, 4, 2, 1, 3, 3 };
            var test = new ShortDistance();
            Assert.AreEqual(11, test.SolveLists(listLeft, listRight));
        }

        [TestMethod()]
        public void SolveListsFromFileTest()
        {
            var listRight = new List<int>();
            var listLeft = new List<int>();
            string[] stringSeparators = new string[] { "   " };
            var lines = File.ReadLines("..\\..\\input.txt");
            foreach (var line in lines)
            {
                
                listLeft.Add(int.Parse(line.Split(stringSeparators, StringSplitOptions.None)[0]));
                listRight.Add(int.Parse(line.Split(stringSeparators, StringSplitOptions.None)[1]));
            }
            var test = new ShortDistance();
            Assert.AreEqual(2285373, test.SolveLists(listLeft, listRight));
        }
    }

}
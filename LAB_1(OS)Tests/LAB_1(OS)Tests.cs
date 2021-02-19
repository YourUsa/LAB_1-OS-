using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LAB_1_OS_;

namespace LAB_1_OS_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumMaxParallelTest1()
        {
            int[][] myArray = new int[][] { new int[] {2,3 }, new int[] { 4, 7 }, new int[] { 1, 3 },
            new int[] { 21, 78 }, new int[] { 6, 39 } };
            int result = Program.SumMaxParallel(myArray, 20);
            int expected = 130;
            Assert.AreEqual(expected, result);
        }

        public void SumMaxParallelTest2()
        {
            int[][] myArray = new int[][] { new int[] {2,3 }, new int[] { 4, 7 }, new int[] { 1, 3 },
            new int[] { 21, 78 }, new int[] { 6, 39 }, new int[] { 7, 3 } };
            int result = Program.SumMaxParallel(myArray, 7);
            int expected = 137;
            Assert.AreEqual(expected, result);
        }

        
    }
}

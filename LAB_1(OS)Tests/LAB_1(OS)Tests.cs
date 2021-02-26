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
            int[][] myArray = new int[][] { new int[] {8, 4, 7 }, new int[] { 14, 9, 0 }, new int[] { 3, 7, 1 },
            new int[] { 21, 7, 9 }, new int[] { 6, 9, 4 } };
            int result = Program.SumMaxParallel(myArray, 20);
            int expected = 59;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SumMaxParallelTest2()
        {
            int[][] myArray = new int[][] { new int[] {2,3 }, new int[] { 4, 7 }, new int[] { 1, 3 },
            new int[] { 21, 78 }, new int[] { 6, 39 }, new int[] { 7, 3 } };
            int result = Program.SumMaxParallel(myArray, 4);
            int expected = 137;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SumMaxParallelPLinqTest()
        {
            int[][] myArray = new int[][] { new int[] {23, 34, 6, 86}, new int[] { 45, 657, 7, 22  }, new int[] {90, 93, 46, 3 },
            new int[] { 11, 32, 33, 65}, new int[] { 45, 68, 33, 57 } };
            int result = Program.SumMaxParallelPLinq(myArray);
            int expected = 969;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void SumMaxParallelTest3()
        {
            int result = Program.SumMaxParallel(Program.Input(586, 908), 4);
            Assert.IsInstanceOfType(result,typeof(int));
        }


    }
}

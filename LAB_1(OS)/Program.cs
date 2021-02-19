using System;
using System.Threading;

namespace LAB_1_OS_
{
    public class Program
    {
        abstract class BaseThread
        {
            private Thread thread;

            protected BaseThread()
            {
                thread = new Thread(new ThreadStart(this.Run));
            }
            public void Start() => thread.Start();
            public void Join() => thread.Join();
            

            public abstract void Run();
  
        }

        class Parallel : BaseThread
        {

            private int count;
            private int[][] nums;

            public Parallel(int[][] nums): base()
            {
                this.nums = nums;
            }

            public override void Run()
            {
                
                for (int i = 0; i < nums.Length; i++)
                {
                    int max = nums[i][0];
                    for (int j = 0; j < nums[i].Length; j++)
                    {
                        if (nums[i][j] > max)
                        {
                            max = nums[i][j];
                        }
                    }
                    count += max;
                    
                }
                
            }
            
            public int GetSum()
            {
                return count;
            }
        }
    

        public static int SumMaxParallel(int[][] myArray, int threadCount)
        {
            int result = 0, sizeSlice=0;
            Parallel [] myThreads = new Parallel[threadCount];
            sizeSlice = myArray.Length / threadCount;
            int a = myArray.Length;
            for (int j = 0; j < threadCount; j++)
            {   if (j != threadCount - 1)
                {
                    myThreads[j] = new Parallel(SubArray(myArray, j * sizeSlice, sizeSlice));
                    a -= sizeSlice;
                }
                else
                {
                    myThreads[j] = new Parallel(SubArray(myArray, j * sizeSlice, a));
                    a = 0;
                }
                myThreads[j].Start();
            }
            for (int j = 0; j < threadCount; j++)
            {
                myThreads[j].Join(); 
            }
            for (int j = 0; j < threadCount; j++)
            {
                result+= myThreads[j].GetSum();
            }
            return result;

        }
        private static int[][] SubArray(int[][] array, int start, int length)
        {
            int[][] result = new int[length][];
            Array.Copy(array, start, result, 0, length);
            return result;
        }

        public static int[][] Input(int a, int b)
        {
            Random rn = new Random();
            int[][] myArray = new int[a][];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    myArray[i][j] = rn.Next();
                }
            }
            return myArray;
        }


    }
}

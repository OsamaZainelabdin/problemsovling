using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 3, 2, 4 };
            Console.WriteLine(FindUnsortedSubarray(nums));
            Console.ReadLine();            
        }

        public static int FindUnsortedSubarray(int[] nums)
        {
            int ix = -1;
            int lx = -1;
            int temp = 0;
            for (int y = 0;y<nums.Length -1; y++)
            {
                for (int x = y+1; x < nums.Length; x++)
                {
                    if (nums[y] > nums[x])
                    {
                        if (ix == -1)
                            ix = y;
                        lx = x;
                        temp = nums[y];
                        nums[y] = nums[x];
                        nums[x] = temp;
                    }
                }
            }
                        
            if (ix == -1)
                return 0;

            return lx - ix + 1;
        }
    }
}

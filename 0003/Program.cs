using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace _0003
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Solution();
            var result = S.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            var result1 = S.RemoveElement(new int[] { 2, 2, 2, 2 }, 2);
            var S1 = new Solution();
            var result2 = S1.Remove(new int[] { 2, 3, 2, 4 }, 2);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
    public class Solution
    {
        public int RemoveElement(int[]nums,int val)
        {
            int slow = 0;
            int fast = 0;
            while (fast < nums.Length)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            this.PrintArray(nums);
            return slow;
        }

        public int Remove(int[] nums,int val)
        {
            int i = 0;
            for(int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            this.PrintArray(nums);//函数之间的调用方式，必须写在return前面，确保函数始终在主线上。打印出来in-place后的nums数组

            return i;
        }

        //函数四要素： [Access Label] [Return Type] [Function Name] ([Parameters])
        public void PrintArray(int[] nums)
        {
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }
    }
    
}

using System;

namespace _0852
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var s1 = new Solution();
            Console.WriteLine(s.PeakIndexInMoutainArray(new int[] { 0, 2, 1, 0 }));
            Console.WriteLine(s1.Peak(new int[] { 1, 2, 3, 4, 1}));
        }
    }
    public class Solution
    {
        public int PeakIndexInMoutainArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return i;
                }
            }

            return default;
        }
        public int Peak(int[] nums)//二分法解决此题
        {
            var left = 0;
            var right = (nums.Length) - 1;
            while (left <right)//因为只存在一个顶点，所以循环条件只能是小于，而非小于等于。当left>right时跳出循环
            {
                var mid = (left + right) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else//nums[mid]>nums[mid+1]
                {
                    right=mid;//当处于下坡时，nums[mid]>nums[mid+1]，此时mid对应的值也许会是顶点位置，所以right=mid。
                }
            }
            return left;
        }
    }
}
 

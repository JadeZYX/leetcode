using System;

namespace _0035
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Solution();
            var result = S.SearchInsert(new int[] {1,3,5,6},5);
            var result1 = S.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            var result2 = S.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    public class Solution
    {
        public int SearchInsert(int[]nums,int target)
        {
            int left = 0;
            int right = (nums.Length )- 1;
            int mid = (left + right) / 2;
            while (left <= right)//循环条件
            {
                if (nums[mid] > target)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;//由于right和left的改变，所以mid也不断改变，从而求mid对应的数值

                }
                if (nums[mid] < target)
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }
                if (nums[mid] == target)
                {
                    return mid;
                }
            }
            return left;
        }
    }
}
//解析：此题给定了一个排序数组和目标值，在数组中找到目标值并返回其索引。若目标值不在数组中，则按照顺序插入数组中。
//考查的是二分法，需要left初始值为下脚0,right初始值为长度-1,以及mid=（left+right)/2取整.然后通过比较下脚mid所对应的数值和目标值，
//若目标值比nums[mid]大，即目标值在nums[mid]的右侧，则left值进行改变，left变成mid+1,right此时不变，重新计算mid,并再次
//比较nums[mid]与target的大小。若nums[mid]>target,即目标值位于nums[mid]左侧，则right左移动，变成mid-1,此时left不变，重新
//计算mid和下脚mid对应的数值。直到nums[mid]==target,返回求出的mid值即可。
//但是存在一种情况，就是当目标值不在原数组中，则需要大小对目标值进行排序。只要left<=right即可满足循环条件。当left>right的时候，返回left。
//此时要么因为目标值小，right不断的左移，甚至左移到left的左侧，不满足循环条件，跳出。返回left.
//要么因为目标值过大，left不断的右移动，甚至右移到right的右侧，不满足循环条件，跳出。返回left.

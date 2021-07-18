using System;
using System.Globalization;

namespace _0053
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.MaxSum(new int[] { -2, 1, 3, 4, -1 }));
        }
    }

    public class Solution
    {
        public int MaxSum(int[] nums)
        {
            var result = int.MinValue;
            int from = 0, to = 0; ;
            Console.WriteLine($"result: {result}");
            for (var i = 0; i < nums.Length; ++i)
            {//此for循环i，和j作为下标组成各种新的数组，简单的说，i,j作为一个区间,从哪个元素开始，到哪个元素结束
                for (var j = i; j < nums.Length; ++j)
                {
                    var sum = this.Sum(nums, i, j);
                    //result = Math.Max(sum, result);
                    //这里运用内置函数Math.Max对传入的两个参数sum,result进行大小比较
                    if (sum > result)
                    {
                        result = sum;
                        from = i;
                        to = j;
                    }

                    Console.WriteLine($"i:{i} j:{j} sum:{sum} result:{result}");
                }
            }

            for (var i = from; i <= to; ++i)
            {
                Console.Write(nums[i] + " ");//把符合情况的元素打印出来
            }

            Console.WriteLine();
            return result;
        }

        private int Sum(int[] nums, int m, int n)//m,n代表了区间，求和方程
        {
            var sum = 0;
            for (var i = m; i <= n; ++i)
            {
                sum += nums[i];
            }

            return sum;
        }
        public int MaxSum1(int[] nums)
        {
            var result = int.MinValue;
            for(int i = 0; i < nums.Length; i++)//这里的两重for循环其实就是区间范围
            {
                var sum = 0;//此处不能在for之外声明，否则sum会不断的更新。这里要求i值改变，sum会清0一次。
                for(int j = i; j < nums.Length; j++)
                {
                    sum = sum + nums[j];
                    result = Math.Max(sum, result);
                }
            }
            return result;
        }
    }
    
}

using System;

namespace _0001
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();//实例化格式
            var result = s.TwoSum(new int[] { 2, 7, 11, 15 }, 9);//输入参数，调用函数，因为直接把参数输入调用，可不命名
            foreach(var i in result)//若之间打印result，后台无法显示数组元素，所以要用foreach来便利所有元素并打印出来
            {
                Console.Write(i+" " );
            }
        }
    }  

    public class Solution//类别

    {
        public int[] TwoSum(int[] nums, int target)//第一个int[]表示函数的输出类型是array,所以如果输出int,不需加[]
        {
            var result = new int[2];//设置一个叫result的变量，new int[]表示初始化array,且里面有两个元素
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j] == target)
                    {
                        result[0] = i;//将i的值赋给数组result的第一个元素
                        result[1] = j;//
                        return result;//此处也可写成result[i,j]
                    }
                }
            }

            return null;//若无符合要求的结果，返回空值
        }
    }
}

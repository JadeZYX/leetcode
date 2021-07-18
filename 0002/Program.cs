using System;
using System.Collections.Generic;
using System.Globalization;

namespace _0002
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Solution();
            var result = S.RemoveDuplicates(new int[] { 0, 0, 0, 1, 1, 2, 2, 3, 4, 4 });
            Console.WriteLine(result);
        }
    }
     
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)//若数组里没有元素，则长度为0
            {
                return 0;
            }

            var slow = 0;//设置变量slow,fast并赋值皆为0.这里的slow和fast有类似于下标
            var fast = 0;
            while (fast < nums.Length)//while循环条件
            {
                if (fast == 0 || nums[fast] != nums[fast - 1])//两个条件满足其一即可进入下一步
                {
                    nums[slow] = nums[fast];//把nums[fast]下标对应的值赋给nums[slow],原nums[slow]值会被覆盖掉，
                                                                //fast+1,成为后面一位
                    slow++;//相当于作为下标的slow+1
                }

                fast++;//相当于作为下标的fast+1
            }

            return slow;//slow这个时候作为下标统计出来的数即为数组没有重复元素的长度
        }
    }
}
//if条件语句第一点的fast==0,在此条件下进入循环后，slow+1=1即为数组里已经存在一个元素了。当数组元素仅有一个时候fast++无法
//再次执行，因为此时的fast的值超出了while循环的条件。
//若数组里没有元素，即为0，则不满足条件跳过循环，直接返回原slow值，即为0.
//运用了in place change,即在原已sorted的数组上进行修改，覆盖原来的数据，同时又能统计出来没有重复数据的数组的长度

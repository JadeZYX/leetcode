using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace basics
{
    public class Sort
    {
        public void BubbleSort(int[] nums)//冒泡排序法,void是不需要有返回值的意思
        {
            for(var i = 0; i < nums.Length - 1; i++)//多轮循环
            {
                for(var j = 0; j < nums.Length - 1-i; j++)//比较相邻的两个数大小,当j=length-1时候，j+1是溢出数组的
                { 
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];//设置临时变量储存元素，交换元素
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(nums);

        }
        public void BubbleSort1(int[] nums)//冒泡排序法2  交换排序
        {
            for(var i = nums.Length - 1; i > 0; i--)//外层循环表需要便利的数组元素的个数，由于最大值的不断冒泡固定并不断的递减
            {
                for(var j = 0; j < i; j++)//内层循环是从0开始到i-1结束，此过程把相邻两个元素的较大值不断后移并固定在最后一位
                {
                    if (nums[j] > nums[j + 1])//因为这里比较的是j和j+1,所以j只需到i-1即可
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(nums);
        }
        public void SelectionSort(int[] nums)//交换排序之选择排序
        {
            for (var i = 0; i <nums.Length-1; i++)
            {
                var minIndex = i;//从小到大排序，将最小的数排在每次循环的最首位，所以内循环的j是从i+1开始，不需要从0开始了
                for (var j = i + 1; j <= nums.Length-1; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }
            Console.WriteLine(nums);
        }
        public void SelectionSort1(int[] nums)//交换排序之选择排序2
        {
            for(var i = nums.Length - 1; i >0; i--)
            {
                var MaxValue = i;//从小到大排序，将最大的数排到每次循环的末尾
                for(var j = 0; j < i; j++)
                {
                    if (nums[j]>nums[MaxValue])
                    {
                        MaxValue = j;
                    }
                }
                var temp = nums[i];
                nums[i] = nums[MaxValue];
                nums[MaxValue] = temp;
            }
            Console.WriteLine(nums);
        }
        public void SelectionSort2(int[] nums)
        {
            for(var i = 0; i < nums.Length; i++)//从前往后排，每求出一个值就替换下来原来位置的值
            {
                var minindex = this.Min(nums, i, nums.Length);
                this.Swap(nums, i, minindex);
            }

            Console.WriteLine();
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private int Min(int[] nums,int from,int to)//记录最小值的位置以便交换元素值
        {
            var minindex = from;
            for(var i = from+1; i < to; i++)
            {
                if (nums[i] < nums[minindex])
                {
                    minindex = i;
                }
            }
            return minindex;
        }

        public void InsertionSort(int[] arr)//插入排序 in-place排序，从后向前扫描，将新元素与前面已经排好序的元素进行大小比较，不断后移，给新元素腾位置
        {
            int preIndex;
            for(var i = 1; i < arr.Length; i++)//i不断的递增所以会遍历到整个数组的所有元素
            {
                preIndex = i - 1;//由于preindex是不断改变的，便于新元素与其前面索引的元素进行大小比较
                var target = arr[i];//若前面索引元素小于目标元素，则将目标元素插入其后preindex+1的位置，若大于，则让前面的元素不断后移
                while (preIndex >= 0 && arr[preIndex] > target)
                {
                    arr[preIndex+1] = arr[preIndex];
                    preIndex--;               
                }
                arr[preIndex + 1] =target;//此时由于preIndex所对应的元素小于目标元素，所以将目标元素插入到preIndex+1的位置
            }
            Console.WriteLine(arr);
        }
        public void ShellSort(int[] arr)//希尔排序是简单插入排序的进阶版，优先比较距离较远的元素，缩小增量排序
        {
            var len = arr.Length;
            for (var gap = len / 2; gap > 0; gap =gap / 2)//第一层循环是针对多次的划分gap，数与数之间的分组
                                                          //比如先是4，数组里的元素即12341234，然后是除以2，121212，然后再除以2，即1111
            {
                for (var i = gap; i < len; i++)//第二层循环以gap为起点记录当前值，i不断++，即gap右侧的数据都会遍历到
                {
                    var preindex=i-gap;
                    var current = arr[i];
                    
                    while (preindex>= 0 && current < arr[preindex])//第三层循环是便利gap点左侧的数据，即与i对应的同组的数据是preindex
                    {
                        arr[preindex+gap] = arr[preindex];//把较大值赋值后移
                        preindex=preindex- gap;
                    }
                    arr[preindex+gap] = current;
                }
            }
            Console.WriteLine(arr);
        }
        
        public void MergeSort(int[] arr)//归并排序,2-路归并，采用了divide and conquer法
        {
            this.Merge(arr, 0, arr.Length - 1);
        }

        private void Merge(int[] arr, int from, int to)
        {
            if (from >= to)
            {
                return;
            }

            var mid = (from + to) / 2;
            this.Merge(arr, from, mid);
            this.Merge(arr, mid + 1, to);
            var buffer = new List<int>();
            int i = from, j = mid + 1;
            while (i <= mid || j <= to)
            {
                if (i <= mid && j <= to)
                {
                    if (arr[i] < arr[j])
                    {
                        buffer.Add(arr[i]);
                        i++;
                    }
                    else
                    {
                        buffer.Add(arr[j]);
                        j++;
                    }
                }
                else if (i <= mid)
                {
                    buffer.Add(arr[i]);
                    i++;
                }
                else
                {
                    buffer.Add(arr[j]);
                    j++;
                }
            }

            Array.Copy(buffer.ToArray(), 0, arr, from, to - from + 1);
        }
        public void CountingSort(int[] arr)//计数排序
        {
            var length = this.MaxValue(arr) + 1;
            int[] Counting = new int[length];//C里的下标代表arr里的元素，C里的元素代表此元素出现的次数
            for (var i = 0; i < arr.Length; i++)//统计arr里每个元素出现的次数，并记录再Counting数组里
            {
                Counting[arr[i]]++;//默认新建的数组里都是0，++后的结果电脑自动储存
            }
            var SortIndex = 0;//此变量用于记录排好序后的arr
            for (var j = 0; j < length; j++)
            { 
                while (Counting[j]> 0)
                {
                    arr[SortIndex]= j;
                    Counting[j]--;
                    SortIndex++;
                }
            }
        }
        public void CountSort(int[]arr)//平移以节省空间，同时若最小值是负整数，也可使用此计数排序
        {
            var min = this.MinValue(arr);
            var max = this.MaxValue(arr);
            var len = max-min + 1;
            int[] count = new int[len];
            for(var i = 0; i < arr.Length; i++)
            {
                count[(arr[i] - min)]++;//arr[i]-min代表将arr里的元素减去最小值，向左平移，节省空间
            }
            var sortedIndex = 0; 
            for(var j = 0; j < len; j++)
            {
                while (count[j] > 0)
                {
                    arr[sortedIndex] = j + min;//因为之前记录的数都是减去最小值平移的，所以现在要加最小值
                    count[j]--;
                    sortedIndex++;
                }
            }
        }
        private int MaxValue(int[] arr)//求最大值，用于新创建数组的长度
        {
            var Max = arr[0];
            for(var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }
        private int MinValue(int[] arr)
        {
            var Min = arr[0];
            for(var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            return Min;
        }
        //0~1000之间的数字，用桶排序法进行排序，使每个桶的数字界限是50
        public void BucketSort(int[] arr)
        {
            var bucketsize = 21;//（1000-0）/50

            // an array of list
            var buckets = new List<int>[bucketsize];
            // var buckets = new int[bucketsize];数组里int表类型，[]表长度

            // a list of array
            // var buckets = new List<int[]>();    list<>表数据类型是个List,int[]表list里是array
            for (var i = 0; i < bucketsize; ++i)
            {
                buckets[i] = new List<int>();//array of list 需要初始化
            }

            for (var i = 0;i< arr.Length; i++)
            {
                var bucketnumber = arr[i] / 50;
                buckets[bucketnumber].Add(arr[i]);
            }

            var j = 0;
            
            for (var i = 0; i < bucketsize; ++i)
            {
                // lanmda
                buckets[i].Sort();//对每个桶list进行快速排序
                foreach (var n in buckets[i])
                {
                    arr[j] = n;//将桶里排好序的数重新放到原来的arr里
                    j++;
                }
            }
        }
        public void RadixSort(int[] arr)//基数排序，先找出最大数，在看最大数的位数
        {
            var digit = this.Digit(this.MaxValue(arr));
            var buckets = new List<int>[10];//array of a list,0-9共10个桶
            for (var i = 0; i < 10; ++i)
            {
                buckets[i] = new List<int>();//对每个桶进行初始化，每个桶里的成员是list类型，可添加
            }

            int mod = 10, div = 1;
            for (var d = 0; d < digit; ++d, mod *= 10, div *= 10)//循环条件可超出三个，灵活使用
            {
                foreach (var n in arr)
                {
                    var i = (n % mod) / div;//先取余再取商
                    buckets[i].Add(n);
                }
                var j = 0;
                foreach (var list in buckets)//遍历每个桶
                {
                    foreach (var n in list)//遍历每个桶里的元素
                    {
                        arr[j] = n;
                        j++;
                    }
                    list.Clear();//清空
                }
            }
        }
        private int Digit(int num)//求某个正整数的位数
        {
            if (num == 0)
            {
                return 1;
            }

            var digit = 0;
            while (num > 0)
            {
                digit++;
                num /= 10;
            }

            return digit;
        }
    }   
}


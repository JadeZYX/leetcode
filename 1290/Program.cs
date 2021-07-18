using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _1290
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            AddToTail(head, 0);
            AddToTail(head, 1);
            Print(head);
            ListNode Head= AddMultiNodes(new int[] { 1, 0, 1 });//这里初始化以1为首节点的单链表
            Print(Head);
            var s = new Solution();
            Console.WriteLine(s.GetDecimalValue(Head));
           Console.WriteLine(s.StringToInt("123"));

        }
        static void AddToTail(ListNode head,int val)
        {
            if (head == null)
            {
                head = new ListNode(val);
            }
            else
            {
                var node = new ListNode(val);
                var p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = node;
            }
        }
        static ListNode AddMultiNodes(int[] nums)
        {
            ListNode head = new ListNode(nums[0]);
            var p = head;
            for(int i = 1; i < nums.Length; i++)
            {
                p.next = new ListNode( nums[i]);//因为要先初始化新的节点才能继续储存value
                p = p.next;
            }
            return head;
        }
        static void Print(ListNode head)
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.val + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0,ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }
    public class Solution
    {
       public int GetDecimalValue(ListNode head)//思路来源于下面的将string类型的数转化成int类型
        {
            var res = 0;
            var p = head;
            while (p != null)
            {
                res = res * 2 + p.val;//因为是二进制，所以是乘以2
                p = p.next;
            }
            return res;
        } 
        public int StringToInt(string a)
        {
            var result = 0;
            for(int i = 0; i < a.Length; ++i)
            {
                var n = a[i] - '0';//char的本质也是int,所以这里的n就转换成int类型了
                result = result * 10 + n;//int类型的十进制的数，所以是*10
            }
            return result;
        }
    }

}

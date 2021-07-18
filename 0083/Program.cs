using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _0083
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            AddToTail(head, 1);
            AddToTail(head, 2);
            Print(head);
            var Head =AddMultiNodes( new int[] { 1, 1, 2, 3, 3 });
            Print(Head);
            var s = new Solution();
            Print(s.DeleteDuplicates(Head));
        }
        static void AddToTail(ListNode head,int value)
        {
            if (head == null)
            {
                head = new ListNode(value);
            }
            else
            {
                var p = head;
                var node = new ListNode(value);
                while (p.next!= null)
                {
                    p = p.next;
                }
                p.next = node;
            }
        }
        static void Print(ListNode head)
        {
            var p = head;
            while (p != null)
            {
                Console.Write(p.val+" ");
                p = p.next;
            }
            Console.WriteLine();
        }
        static ListNode AddMultiNodes(int[] nums)
        {
            var head = new ListNode(nums[0]);
            var p = head;
            for(int i = 1; i < nums.Length; i++)
            {
                p.next = new ListNode(nums[i]);
                p = p.next;
            }
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0,ListNode next=null)//默认初始化值及下个节点为null
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var p = head;
            while (p.next!= null)//因为假如p.next==null,则p.next上就没有节点没有值，无法进入if循环
            {
                if (p.val != p.next.val)
                {
                    p = p.next;
                }
                else
                {
                    p.next = p.next.next;
                }
            }
            return head;
        }
        //此题强调链表如果存在是个有序列表，这个的意义在于不需要重复循环，一旦出现重复节点，直接将指针指向下一个的
        //下一个，若不是个有序的列表，则需要多次循环。还要注意是需要考虑p!=null还是p.next!=null
    }
}

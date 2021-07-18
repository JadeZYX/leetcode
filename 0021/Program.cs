using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace _0021
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            AddToTail(head, 2);
            AddToTail(head, 4);
            Print(head);
            var head1 = AddMultiNodes(new int[]{1,3,4});
            Print(head1);
        }
        static void AddToTail(ListNode head, int value)
        {
            if (head == null)
            {
                head = new ListNode(value);
            }
            else
            {
                var node = new ListNode(value);//同一namespace下，所以即使不是同一class也可调用
                var p = head;
                while (p.next!= null)//循环条件不能是p!=null,因为要确保原来的p在tail,且和新的节点链接一起
                {
                    p = p.next;
                }
                p.next = node;//之前的p不是null,且要指针指向下一个，这样才能把链表链接起来
            }
        }
        static ListNode AddMultiNodes(int[]nums)
        {
            var head = new ListNode(nums[0]);
            var p = head;
            for (int i = 1; i < nums.Length; ++i)
            {
                p.next = new ListNode(nums[i]);//使用p.next是确保将指针指向下一个且将链表链接起来
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
            Console.WriteLine( );
        }
    }
    public class ListNode//这里不管是private还是public,虽不在同一类下，但只要在同一namespace下都可调用
    {                     //不在同一个namespace下,private不可调用
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    /*public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1,ListNode l2)
        {

        }
    }*/
}

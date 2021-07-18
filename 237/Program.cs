using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _237
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode head = new ListNode(4);
            AddToTail(head, 5);
            AddToTail(head, 1);
            AddToTail(head, 9);
            Print(head);
            AddToTail(head, 0);//因为此操作在上一行的print之后，所以打印出的结果不包含0
            ListNode Head = AddMultiNodes(new int[] { 4, 1, 5, 9, 0, 3 });
            Print(Head);
            var s = new Solution();
            s.DeleteNode(head.next);//注意参数是节点，这里的head.next就是随意写的第二个节点
            Print(head);           
        }
        static void AddToTail(ListNode head,int value)
        {
            if (head == null)
            {
                head = new ListNode(value);
            }
            ListNode node = new ListNode(value);
            ListNode p = head;
            while (p.next!= null)
            {
                p = p.next;
            }
            p.next = node;
        }
        static void Print(ListNode head)
        {
            ListNode p = head;
            while (p!= null)
            {
                Console.Write(p.val+" ");
                p = p.next;
            }
            Console.WriteLine();
        }
        static ListNode AddMultiNodes(int[] nums)//因为传入的参数就是数组，没有节点，所以直接初始化首节点为数组第一个即可
        {
            ListNode head = new ListNode(nums[0]);
            var p = head;
            for(int i = 1; i < nums.Length; ++i)
            {
                p.next=new ListNode(nums[i]);
                p = p.next;
            }
            return head;
        }

        }
    }
    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int x){ 
            this.val = x; 
       }
    }
 
    public class Solution
    {
        public void DeleteNode(ListNode node)//这里的node就是需要删除的节点
        {
        node.val = node.next.val;
        node.next = node.next.next;
        }
    }
//利用下一个节点辅助删除需要删除的节点。首先将需要下一个节点的value储存在需要删除的节点上，这时候需要删除的节点
//和下一个节点所储存的value都是一样的，然后将需要删除的节点的指针直接指向下一个的下一个即可。
//因为已经将需要删除的节点的值换成了其下一个节点的值

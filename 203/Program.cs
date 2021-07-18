using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace _203
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var head = new ListNode(1);//初始化head
            AddToTail(head, 2);
            AddToTail(head, 4);
            AddToTail(head, 6);
            AddToTail(head, 6);
            AddToTail(head, 3);
            AddToTail(head, 4);
            AddToTail(head, 5);
            AddToTail(head, 6);
            //Print(head);//因为AddMultipleNodes,AddToTail，Print都在program类下，所以直接使用，不需要实例化后在调用。
            
            var Head = AddMultipleNodes(new int[] { 1, 2, 6, 3, 4, 5, 6});
            Print(Head);
            var s = new Solution();
           ListNode result = s.RemoveElements(head, 6);
            Print(head);
            
        }

        static ListNode AddMultipleNodes(int[] arr)
        {
            var head = new ListNode(arr[0]);
            var p = head;
            for (var i = 1; i < arr.Length; ++i)
            {
                p.next = new ListNode(arr[i]);
                p = p.next;
            }
            return head;
        }

        static void AddToTail(ListNode head, int val)
        {
            if (head == null)
            {
                head = new ListNode(val);
            }
            else
            {
                var node = new ListNode(val);
                var p = head;
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
                Console.Write($"{p.val} ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            if (head == null)
            {
                return null;
            }

            var current = head;
            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;//等号左侧的current.next起到了改变指针指向的作用,但节点位置不变
                }
                else
                {
                    current = current.next;//不需要改变原指针方向，只是改变节点
                }
            }

            return head;
        }
    }
    
    

     public class ListNode
     {
          public int val;
          public ListNode next;
          public ListNode(int val=0)//此处0是默认值，如果之后不赋值，则为0，如果赋值，则为其赋值的值
          {
              this.val = val;
          }
     }
}

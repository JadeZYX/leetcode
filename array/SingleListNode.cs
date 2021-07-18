using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
   
    public class SingleListNode  //head
    {
        public int Value;//成员变量

        public SingleListNode Next;//此时指针指向null

        public SingleListNode(int value)//构造函数，构造函数的名称跟class保持一致
        {
            this.Value = value;//类下的成员变量初始化，给成员变量赋值
        }
    }

    public class SingleLinkedList
    {
        public SingleListNode Head;//单链表的成员变量，给单链表节点定义一个头，默认值是null

        public void Print()
        {
            var p = this.Head;//这里的head是一个头节点，不是value，此时p就是头节点。
            while (p != null)
            {
                Console.Write($"{p.Value} ");//节点的值
                p = p.Next;//指向下一个节点
            }

            Console.WriteLine();
        }

        public void AddToHead(int value)
        {
            if (this.Head == null)
            {
                this.Head = new SingleListNode(value);//因为Head是一个Node,跟value不是同一个类型，所以不能直接赋值，this.Value=value
            }
            else
            {
                var node = new SingleListNode(value);//通过构造函数初始化新的节点并赋值value，直接用this.用于同class下的成员变量和成员函数。
                node.Next = this.Head;//node的next指向Head
                this.Head = node;//将node节点设置成头节点
            }
        }

        public void AddToTail(int value)
        {
            if (this.Head == null)//若节点为空，开一个头节点
            {
                this.Head = new SingleListNode(value);
            }
            else
            {
                var node = new SingleListNode(value);
                var p = this.Head;//p 其实是Node类型
                while (p.Next != null)
                {
                    p = p.Next;
                }

                p.Next = node;//调用上面初始化的node
            }
        }
       
        public void AddToMid(int value1,int value2,int target)
        {
            if (this.Head == null)
            {
                this.Head = new SingleListNode(target);
            }
            else
            {
                SingleListNode i = this.Head;
                while (i != null && i.Value != value1)
                {
                    i = i.Next;
                }
                SingleListNode j = this.Head;
                while (j != null && j.Value != value2)
                {
                    j = j.Next;
                }
                var m = new SingleListNode(target);
                i.Next = m;
                m.Next = j;
            }
        }
    }

    
           
}

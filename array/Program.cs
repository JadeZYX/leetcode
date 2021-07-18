using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Headers;
using System.Threading;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var singleList = new SingleLinkedList();
            singleList.AddToHead(1);
            singleList.AddToHead(2);
            singleList.AddToHead(3);
            singleList.AddToHead(4);
            singleList.Print();
 
            var s = new SingleLinkedList();
            s.AddToHead(1);
            s.AddToHead(2);
            s.AddToHead(3);
            s.AddToHead(4);
            s.AddToMid(3, 2, 6);
            s.AddToTail(0);
            s.Print();
        }
    }   
    // int, float class都是一种type,但class 稍复杂，它是把一系列的成员变量，成员函数，构造函数打包在一起，初始化也有所不同
}


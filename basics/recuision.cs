using System;
using System.Collections.Generic;
using System.Text;

namespace basics
{
    public class Recuision
    {
        //递归即递进回归，recuision,递归函数是指函数调用其自身本身。递归三要素：base case,分解问题，组合问题,
        //也可为第一确定函数是要干什么的，功能；第二寻找递归的结束条件，否则会函数会一直调用自身，进入无底洞，即参数为啥时，
        //递归结束，之后把结果返回；第三不断缩小参数范围，找出原函数等价关系式，可通过一些辅助变量或操作，使原函数结果不变。
        public int FuncAdd(int n)//求当前数等于前两个数之和，斐波那契数列Fibonacci中本身就无复数存在
        {   
            if (n<=2)//循环结束条件
            {
                return 1;
            }

            return FuncAdd(n - 1) + FuncAdd(n - 2);//不断的改变input,调用函数本身
        }
        public int Factorial(int n)//n的阶乘即为n!
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        
        public int FF(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            var x = FF(n - 1);
            return n * x;

        }
    }



}

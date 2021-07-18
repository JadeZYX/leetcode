using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace basics
{
    class Program
    {

        static void Main(string[] args)
        {
            var S = new Sort();//实例化
            var nums = new int[] { 34, 12, 6, 2, 8, 33 };
            var nums1 = new int[] { 99, 54, 78, 0, 2, 5, 88, 9};
            var nums2 = new int[] { 10, 8 };
            var nums3 = new int[] { 3, 2, 6, 9, 5, 3, 6 };
            S.BubbleSort(nums);//调用函数，注意没有返回值，直接调用并传入参数
            //S.BubbleSort1(nums1);
            //S.SelectionSort(nums);
            //S.SelectionSort1(nums1);
            //S.SelectionSort2(nums1);
            //S.InsertionSort(nums1);
            //S.ShellSort(nums);
            //S.ShellSort(nums1);C:\Users\yxzha\source\repos\leetcode\basics\Program.cs
            //S.MergeSort(nums2);
            //S.CountingSort(nums3);
            //S.CountSort(nums3);
            //S.BucketSort(nums1);
            foreach(var m in nums)//便利数组里的所有元素
            {
                Console.Write(m+" ");
            }
            Console.WriteLine();
            foreach(var n in nums1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            foreach(var nn in nums3)
            {
                Console.Write(nn+" ");
            }
            Console.WriteLine();
           var SS = new Recuision();
            // var result = SS.FuncAdd(-1);
            //Console.WriteLine(result);
            //Console.WriteLine(SS.Factorial(5));
            //Console.WriteLine(SS.FF(5));


            
            /*Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            var a = 1;
            Console.WriteLine(a);
            Console.WriteLine("Hello World!");

            var b = new int[] { 1, 2, 3 };
            b[0] = 4;

            Console.WriteLine(b[1]);

            // foreach variable x in array b, print x
            foreach (var x in b)
            {
                Console.WriteLine(x);
            }

            // foreach index of array b, print b[i]
            for (var i = 0; i < b.Length; ++i)
            {
                Console.WriteLine(b[i]);
            }

            // string array
            var c = new string[] { "Jade" };
            Console.WriteLine("Frighting");
            Console.WriteLine("Hope everything will be ok");
            int money = 200;
            int money2;
            money2 = 100;
            string title = "night";
            string a1, b1, c1;
            a1 = b1 = c1 = "good";
            const double price1=366;
            const double price2=price1*2;
            
            Console.WriteLine($"{price1},{price2}");
            Console.WriteLine($"{money+money2}, {a1}{title},{money2}");
            int C = 89;
            int Csharp=90;
            int SQL = 60;
            int averange = (C + Csharp + SQL) / 3;
            Console.WriteLine((C+Csharp+SQL)/3);
            Console.WriteLine(averange);
            Console.WriteLine("my averange score" + averange);
            Console.WriteLine($"averange score: {averange}");
            int j = 45;
            double ii = 0;
            double result1 = j / ii;
            double result2 = ii / j;
            Console.WriteLine($"{result1},{result2}");
            double m = -6.5;
            int n = 2;
            Console.WriteLine($"{m / n},{m % n}");
            int d = 10;
            int pp= 20;
            Console.WriteLine($"{d++},{d++}");
            Console.WriteLine($"{--pp},{--pp}");
            int ACsharp = 80;
            int BCsharp = ACsharp;
            Console.WriteLine(BCsharp);
            int age0 = 33;
            int age1 = 2;
            Console.WriteLine("I will be " + (age0 += 5) + " after five years");
            Console.WriteLine($"Shirley will be {age1 += 5} after five years");
            byte aa = 1;
            Console.WriteLine(aa += 2);
            int number1 = 3, number2 = 5,number3 = 5;
            Console.WriteLine($"{number1 >= number2},{number2 == number3}," +
                $"{number3 < number1}," +
                $"{number2 != number3}");
            Console.WriteLine((number1 < number2) &&(number2==number3));
            Console.WriteLine((number1 > number2) || (number2 == number3));
            Console.WriteLine("please log in");
            string name = Console.ReadLine();
            Console.WriteLine("please input password");
            string pwd = Console.ReadLine();
            if(name=="abc"&&pwd=="def")
            {
                Console.WriteLine("log in successfully");
            }
            else
            {
                Console.WriteLine("log in unsuccessfully");
            }
          
            Console.WriteLine("Please type the password");
            int pwd1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type the password key");
            int keyd = Convert.ToInt32(Console.ReadLine());
            int pwdkey = pwd1 ^ key;
            Console.WriteLine(pwdkey);
           
            int num = 368;
            Console.WriteLine($"zuo yi 2 wei  {num << 2},you yi 2 wei {num >> 2}");
            int num1 = 123;
            PrintBytes(num1);
            PrintBytes(~num1);
            Console.WriteLine((~num1));
            int num2 = -80;
            Console.WriteLine((num2 >> 2));
            double age = 34.4;
            string info = age >= 40 ? "yes" : "no";
            Console.WriteLine(info);
            int num00 = 300, num11 = 400, num22 = 500, num33 = 600;//条件运算符
            int result = num00 > num11 ? num22 :( num33 > num22 ? num33 : num22);
            Console.WriteLine(result);
            int a, b;
            a = 10;
            b = 5;
            int outcome = a <= b ? a : b;
            Console.WriteLine(outcome);
            Char ABC= 'P';
            int she = 3;
            Console.WriteLine($"1.2{ABC},{she}{ABC}");
            int tt = (int)3.1214;
            Console.WriteLine(tt);
            double uu = 3.22;
            int uuu = Convert.ToInt32(uu);
            Console.WriteLine(uuu);
            Console.WriteLine("Please type a number");
            int inum=Convert.ToInt32(Console.ReadLine());
            string reSult = (inum % 2 == 0 ? "even" : "odd");
            Console.WriteLine(reSult);
            if (inum % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
            Console.WriteLine("Please type in the bank name");
            string bankname = Console.ReadLine();
            if (bankname=="ICBC")
            {
                Console.WriteLine("bank of GongShang,CH");
            }
            else if (bankname=="CBC")
            {
                Console.WriteLine("bank of JianShe,CH");
            }
            else if (bankname == "ABC")
            {
                Console.WriteLine("bank of NongYe,CH");
            }
            else
            {
                Console.WriteLine("Please type the right bank name");
            }
            
            Console.WriteLine("please put a year time");  //闰年问题 四年一润百年不润四百年再润
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("This is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not a leap year");
                    }

                }
                else
                {
                    Console.WriteLine("This is a leap year");
                }
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }

            Console.WriteLine(IsLeapYear(2000));
            Console.WriteLine(IsLeapYear(2015));
            
            Console.WriteLine("please type in bank name");   //switch的应用
            string name = Console.ReadLine();
            switch (name)
            {
                case "ICBC":
                case "icbc":
                    Console.WriteLine("bank of gongshang");
                    break;
                case "CBC":
                case "cbc":
                    Console.WriteLine("bank of jianshe");
                    break;
                case "ABC":
                case "abc":
                    Console.WriteLine("bank of nongye");
                    break;
                default:
                    Console.WriteLine("wrong name bank");
                    break;

                       
            }
          
            int n = 1;
            int sum = 0;
            while (n <= 100)//while 法求1到100之和
            {
                sum = sum + n;
                n += 1;
            }
            Console.WriteLine(sum);
            int nn = 1;
            int sum1=0;//do while 求1到100之间数相加之和
            do
            {
                sum1 += nn;
                nn += 1;
            } while (nn<= 100);
            Console.WriteLine(sum1);
            int i=1;
            int sum2=0;
            for (; i <= 100; i++)//for循环变体，最前面的分号
            {
                sum2 += i;
            }
            Console.WriteLine(sum2);

            for (int a = 1; a <= 9; a++)//打印九九乘法表
            {
                for (int b = a; b <= 9; b++)
                {
                    Console.Write($"{a} * {b} = {a * b}\t ");
                }

                Console.WriteLine();
            }
            for(int iRow = 1; iRow <= 9; iRow++)//打印九九乘法表
            {
                for(int iColum = 1; iColum <= iRow; iColum++)
                {
                    Console.Write($"{iColum}*{iRow}={iColum * iRow}\t");//write和writeline的区别
                    Console.Write("{0}*{1}={2}\t", iColum, iRow, iColum * iRow);//占位符的应用
                }
                Console.WriteLine( );
            }
            int q , total = 0;//求2+4+6+8+....100的和 for循环+if else语句解法
            for (q = 1; q <= 100; q++)
            {
                if (q % 2 == 0)
                {
                    total += q;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(total);
            
            int q1 = 2, total1 = 0;//求2到100的偶数之间的和 do while方法
            do
            {
                if (q1 % 2 == 0)
                {
                    total1 += q1;
                    q1++;
                    
                }
                else
                {
                    q1++;
                    continue;
                }
            } while (q1 <= 100);
            Console.WriteLine(total1);
            int q2 = 0, total2 = 0;//使用while循环来求1到100之间偶数之和
            while (q2 <= 100)
            {
                if (q2 % 2 == 0)
                {
                    total2 += q2;
                    q2++;
                }
                else
                {
                    q2++;
                    continue;
                }
            }
            Console.WriteLine(total2);
            */
            int[] a = new int[4];
            a[0] = 0;
            a[1] = 1;
            a[2] = 2;
            a[3] = 3;
            //int数组的初始化：告知长度，不告知长度但全部列出其元素
            int[] aa = new int[] { 0, 1, 2, 3 };
            //int[] aaa = { 0, 1, 2, 3 };
            //int[] aaaa = new int[5] { 0, 1, 2, 3, 4 };
            char[] b = new char[3];
            b[0] = 'a';
            b[1] = 'b';
            b[2] = 'c';
            //char[] bb = new char[] { 'a', 'b', 'c' };
            //char[] bbb = { 'a', 'b', 'c' };
            int[] month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{i + 1} yue you {month[i]} tian");
                Console.WriteLine(month.Length);
                
            }
            //foreach的运用
            foreach(int month11 in month)
            {
                Console.Write(month11+" ");
            }
            int[,] aab = new int[2, 3];//二维数组的使用和初始化，2个[][]或者是1个[ ，]需要加
            char[][] name1 = new char[2][];
            name1[0] = new char[3];
            name1[1] = new char[4];
            int[,] myar = new int[2, 2];
            myar[0, 0] = 2;
            myar[0, 1] = 1;
            myar[1, 0] = 5;
            myar[1, 1] = 9;
            int[][] myarr = new int[2][];
            myarr[0] = new int[3] { 2, 1, 3 };
            myarr[1] = new int[] { 5, 9 };
            int[,] myarrr = new int[2, 2] { { 22, 23 }, { 29, 21 } };
            int[,] myarrrr = new int[,] { { 22, 34 }, { 34, 12 } };
            int[,] myarrrrr = { { 12, 13 }, { 31, 45 } };
            Console.WriteLine(myarrr.Length);

            //1,2,3,4,5,6,7,8,9-----1,4,7,2,5,8,3,6,9
            int[,] array0 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int temp;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{array0[i,j]}  ");
                }
                Console.WriteLine( );
            }
            foreach(var array1 in array0)
            {
                Console.Write(array1 + " ");
            }
            Console.WriteLine();
            for(int m = 0; m < 3; m++)
            {
                for(int n=0;n<m & n < 3; n++)
                {
                    temp = array0[n, m];
                    array0[n, m] = array0[m, n];
                    array0[m, n] = temp;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array0[i, j]}  ");
                }
                Console.WriteLine();
            }
            foreach (var array1 in array0)
            {
                Console.Write(array1 + " ");
            }
            Console.WriteLine();
            char[] charArray = { 'a', 'b', 'c', 'd','e','f' };
            string aA = new string(charArray);//利用构造函数对string初始化值
            Console.WriteLine(aA);
            string aB = new string(charArray, 2, 4);//起始位置，获取个数
            Console.WriteLine(aB);
            string str1 = "123.5 6";
            int size = str1.Length;//获取字符串的长度
            char ch = str1[4];
            Console.WriteLine(size);//获取字符串string中某个char
            Console.WriteLine(ch);
            string str2 = "we are the world";
            int index1 = str2.IndexOf('e');//获取子字符的索引位置，首个出现，从前往后
            int index2 = str2.IndexOf('e', 3);//获取索引位置，3从第几个字符开始
            int index3 = str2.IndexOf('e', 3, 5);//3从第几个字符开始，5要查询的字符个数
            int index4 = str2.LastIndexOf('e');//从后往前查询首次出现的位置
            Console.WriteLine($"{index1} {index2} {index3} {index4} ");
            string Filename = "Program.cs";
            bool bl1 = Filename.EndsWith(".CS");//判断字符串的结尾内容，区分大小写
            bool bl2 = Filename.EndsWith(".CS", true, null);//true表示忽略大小写
            Console.WriteLine($"{bl1} {bl2}");
            string slogan = "Keep on going and never give up";
            bool bl3 = slogan.StartsWith("keep");//判断字符串的开头内容，区分大小写
            bool bl4 = slogan.StartsWith("Keep");
            bool bl5 = slogan.StartsWith("keep", true, null);//判断字符串的开头内容，大小写不受影响
            Console.WriteLine($"{bl3} {bl4} {bl5}");
            string str3 = "123" + "456";//字符串的拼接，或者用str3+="456"
            string str4 = str3 + "abc";
            Console.WriteLine($"{str3}     {str4}");
            //compare法比较字符串，可直接用，不需再设置变量，返回int值，0表同，-1表str1<str2,1表str1>str2
            //CompareTo方法是面对对象的，不能直接用，要用str1.CompareTo(str2),返回值同string.Compare
            //Equals方法返回bool值,string.Equals（str1,str2)或str1.Equals(str2)
            string str5 = "dream";
            string str6 = "Dream";
            string str7 = "drea";
            Console.WriteLine(string.Compare(str5, str6, true));//true表忽略大小写
            Console.WriteLine(string.Compare(str5, str6));//区分大小写
            Console.WriteLine(string.Compare(str5, str7));
            Console.WriteLine(str5.CompareTo(str6));
            Console.WriteLine(string.Equals(str6, str7));
            Console.WriteLine(str5.Equals(str6));
            string str8 = "Learn and live";
            string strUp = str8.ToLower( );//字符串的小写转换
            string strLow = str8.ToUpper();//字符串的大写转换
            Console.WriteLine($"{strUp}   {strLow}");
            Console.WriteLine(string.Format("{0:c0}", 368));//对参数368进行金额格式化，
            //{}是段位符，c0表不保留小数，若是c,则结果为368.00
            Console.WriteLine("ke xue ji shu fa:{0:E}", 1200000.1);//E
            Console.WriteLine("fen ge shu zi xian shi:{0:N}", 1234567);//三位一个逗号
            Console.WriteLine("Π qu 2wei xiao shu xian shi:{0:f2}",Math.PI);
            //F2表示小数点后保留2位，Math.PI表示Π
            Console.WriteLine("16jin zhi xian shi:{0:x}", 33);//x表示16进制，33表传入参数
            Console.WriteLine("bai fen bi xian shi:{0:p0}", 0.99);//P表示百分比
            DateTime strtime = DateTime.Now;//=左侧的DateTime表是类型，同int,string等
            Console.WriteLine(string.Format("duan ri qi:{0:d}", strtime));//d表7/17/2020
            Console.WriteLine(string.Format("chang ri qi ge shi:{0:D}", strtime));//D格式：星期几，几月几号，哪年
            Console.WriteLine("wan zheng ri qi:{0:f}", strtime);//f格式包含了日期和几点几分
            Console.WriteLine("duan shi jian ge shi:{0:t}", strtime);//t是几点几分
            Console.WriteLine("chang shi jian:{0:T}", strtime);//T是几点几分几秒
            Console.WriteLine("yue ri ge shi:{0:M}", strtime);//M或m是月日，如July 17
            Console.WriteLine("nian yue ge shi:{0:y}", strtime);//y或者Y是月年，如july,2020
            //字符串的格式化有两种方法，string.Format()，和ToString()
            int price = 28;
            Console.WriteLine(price.ToString("C0"));//将price转成标准价格模式，C要加双引号，C后有0表不要小数部分
            Console.WriteLine(strtime.ToString("F"));//用ToString法转换f/F全时间格式
            //截取字符串的方法：一是从起始位置到结尾，二是从起始位置到需要截取的位置长度
            string id = "390401198612168909";
            string birth= id.Substring(6);//Substring表截取原字符串的子字符串；6表开始截取的位置，直到结尾
            string birthday = id.Substring(6, 8);//8表需要截取的长度，即个数
            Console.WriteLine($"{birth}   {birthday}");
            //截取文件的文件名称和其扩展名，使用substring和索引indexof法
            string file = "program.cs";
            string flieName = file.Substring(0, file.IndexOf("."));//取program
            string extensionName = file.Substring(file.IndexOf("."));//取.cs
            Console.WriteLine($"{flieName} ,  {extensionName}");
            //字符串的分割:将字符串以某指定分割符号分割成字符数组,Split,可指定分割次数
            string strletter = "abc,def,ghi,jklmn";
            string[] strarray = strletter.Split(new char[]{ ','});
            foreach (string partstr in strarray)//需要使用foreach把分割后的元素打印出来
            {
                Console.Write(partstr+"  ");
            }
            Console.WriteLine();
            string str = "192.168.0.1";
            string[] firstArray = str.Split(new char[] { '.' });
            string[] secondArray = str.Split(new char[] { '.' }, 3);//3表是分割的次数
            foreach(string partstr1 in firstArray)
            {
                Console.Write(partstr1 + "  ");
            }
            Console.WriteLine();
            foreach(string partstr2 in secondArray)
            {
                Console.Write(partstr2 + "  ");
            }
            Console.WriteLine();
            //移除字符串前后的空格或者开头结尾的指定字符---trim
            string strword = " a b c ";
            string shorstr = strword.Trim();
            Console.WriteLine(shorstr);
            string strold = "***hello&&&Y@";
            char[] ch00 = { '*','&','@','Y'};//设置一个字符数组来记录需要移除的指定字符，可以是多个字符
            string strnew = strold.Trim(ch00);
            Console.WriteLine(strnew);
            string strOld = "one world,one dream";
            string strNew = strOld.Replace("one", "ONE");//Replace可替换单个字符或字符串
            Console.WriteLine(strNew);
            //可变字符串类String Builder
            StringBuilder question = new StringBuilder("(),(),(),2,4,6,7,8");//创建时等号右边有个new
            Console.WriteLine(question);
            question.Remove(0, 9);//移除：0表起始位置，9表个数
            question.Insert(0, "(men qian da qiao xia),(you guo yi qun ya),(kuai lai kuai lai shu yi shu) ");
            Console.WriteLine(question);


                



                



           

        }






        static void PrintBytes(int num)
        {
            for (var i = 0; i < 32; ++i)
            {
                Console.Write(num & 0x01);
                num >>= 1;
            }

            Console.WriteLine();
        }
        static bool IsLeapYear(int year)
        {
            if(year%4==0)
            {
                if(year%100==0)
                {
                    if(year%400==0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;

        }
      
      
            



    }
}       

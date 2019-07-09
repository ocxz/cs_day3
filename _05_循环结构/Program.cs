using System;

namespace _05_循环结构
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while循环的学习  向控制台打印100遍 下次考试我一定要细心
            //// 向控制台打印100遍 下次考试我一定要细心
            //// 循环体：Console.WriteLine("下次考试我一定要细心");
            //// 循环条件：打印次数小于100遍
            //// 需要定义一个循环变量记录循环次数，循环一次加一

            //int i = 0;  // 循环变量
            //while (i < 100)  // 循环条件
            //{
            //    Console.WriteLine("下次考试我一定要细心\t{0}",i);   // 循环体
            //    i++;   // 循环一次，自身加一
            //}
            //Console.ReadKey(); 
            #endregion

            #region while循环的学习  求1-100之间所以整数的和
            //// 求1-100之间所以整数的和
            //// 循环体 sum += i;  累加的过程
            //// 循环条件 i<=100;
            //// 循环变量 int i = 1;
            //// 循环控制 i++;

            //int sum = 0;   // 声明变量，用来存储总和
            //int i = 1;
            //while (i <= 100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("1到100所有整数和为{0}", sum);
            //Console.ReadKey(); 
            #endregion

            #region while循环的学习 求1-100之间所有偶数的和

            //// 求1-100之间所有偶数的和
            //// 循环体  sum +=i; 累加的过程
            //// 循环条件 i<=100;
            //// 循环变量 int i = 2;    2是1-100间第一个偶数  
            //// 循环控制 i+=2;

            //int sum = 0;  // 声明一个变量， 用来存储总和
            //int i = 2;   // 1-100间第一个偶数
            //while (i <= 100)
            //{
            //    sum += i;
            //    i += 2;
            //}

            //Console.WriteLine("1-100间的偶数和为{0}", sum);
            //Console.ReadKey(); 
            #endregion
        }
    }
}

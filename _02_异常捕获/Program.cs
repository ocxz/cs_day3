using System;

namespace _02_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 异常概念的学习和练习

            // 异常定义：语法上没有错，运行时由于某些原因出错，不能正常运行

            int number = 0;
            bool flag = true;
            Console.WriteLine("请输入一个数字");
            try
            {
                // 若输入的为非数字，则会抛出异常
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的内容不能转换成数字");
                flag = false;
            }

            // 让代码满足条件执行，最简单的办法就是设一个bool类型标志位
            if (flag)
            {
                Console.WriteLine(number * 2);
            }

            Console.ReadKey();

            #endregion
        }
    }
}

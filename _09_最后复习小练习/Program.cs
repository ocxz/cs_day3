using System;

namespace _09_最后复习小练习
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 不断要求用户输入学生姓名，输入q结束

            //// 循环体：提示并接收用户输入
            //// 循环条件：用户输入不为q

            //string stuName = "";
            //while (stuName != "q")
            //{
            //    Console.WriteLine("请输入学生姓名（按q停止输入）");
            //    stuName = Console.ReadLine();
            //}

            //Console.WriteLine("输入完成！");
            //Console.ReadKey();
            #endregion

            #region 要求用户输入一个数字，打印两倍，按q结束

            //// 循环体：提示并接收数字，打印两倍
            //// 循环条件：用户输入不为q

            //string uInput = "";
            //do
            //{
            //    Console.WriteLine("请输入一个数字，我们会计算两边(按q结束)");
            //    uInput = Console.ReadLine();
            //    if (uInput != "q")
            //    {
            //        try
            //        {
            //            Console.WriteLine("{0}的两边是{1}", Convert.ToInt32(uInput), Convert.ToInt32(uInput) * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的格式不正确，请按任意键重新输入");
            //            Console.ReadKey();
            //        }
            //    }
            //} while (uInput != "q");

            //Console.WriteLine("程序退出");
            //Console.ReadKey();

            #endregion

            #region 不断输入一个正整数，输入end结束输入，显示输入的数字中的最大值

            //// 循环体：不断输入正整数
            //// 循环条件：用户输入不为end

            //int maxValue = 0;
            //string uInput = "";

            //while (true)
            //{
            //    Console.WriteLine("请输入一个正整数（输入end结束)");
            //    uInput = Console.ReadLine();
            //    if (uInput == "end")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        try
            //        {
            //            maxValue = maxValue > Convert.ToInt32(uInput) ? maxValue : Convert.ToInt32(uInput);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入不是正整数，无效，按任意键，重新输入");
            //        }
            //    }

            //}

            //Console.WriteLine("刚刚输入的数字中，最大的为{0}", maxValue);
            //Console.ReadKey();

            #endregion

        }
    }
}

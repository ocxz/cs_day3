using System;

namespace _06_break的用法
{
    class Program
    {
        static void Main(string[] args)
        {

            #region break跳出当前循环  单个循环测试

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("我执行了{0}次", i);
            //    i++;
            //    break;  // 跳出当前循环
            //}

            #endregion

            #region break跳出当前循环 双重循环测试
            //int i = 1;
            //int j = 1;
            //while (i <= 10)
            //{
            //    while (j <= 10)   // 符合i<=100执行的循环体
            //    {
            //        Console.WriteLine("我是里面的循环\t{0}",j);   // 符合j<=100执行的循环体
            //        j++;
            //        break;    // 跳出当前循环
            //    }

            //    Console.WriteLine("我是外面的循环\t{0}", i);
            //    i++;
            //}

            //Console.ReadKey(); 
            #endregion

            #region 要求用户输入用户名和密码，用户名只要不是admin、密码不是password就提示，重新输入
            //// 要求用户输入用户名和密码，用户名只要不是admin、密码不是password就提示，重新输入
            //// 循环体：提示用户输入接收用户名和密码，判断是否登录成功
            //// 循环条件：用户名或密码错误

            //string userName = "";
            //string userPwd = "";
            //while (userName != "admin" || userPwd != "password")
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码");
            //    userPwd = Console.ReadLine();
            //}
            //Console.WriteLine("登录成功");
            //Console.ReadKey(); 
            #endregion

        }
    }
}

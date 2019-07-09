using System;

namespace _08_dowhile循环
{
    class Program
    {
        static void Main(string[] args)
        {

            #region while实现 明天小兰就要登台演出了，老师说再唱一遍，满意小兰就可以回家了，不满意再练一般，满意为止（y/n);
            //// 明天小兰就要登台演出了，老师说再唱一遍，满意小兰就可以回家了，不满意再练一般，满意为止（y/n);

            //// 循环体：小兰唱一遍，问老师满意吗，老师回答
            //// 循环条件：不满意

            //Console.WriteLine("老师，我唱的您满意吗？y/n");
            //string answer = Console.ReadLine();
            //while (answer == "n")
            //{
            //    Console.WriteLine("老师，我再唱一遍，您现在满意吗？y/n");
            //    answer = Console.ReadLine();
            //}

            //Console.ReadKey(); 
            #endregion

            #region do-while实现 明天小兰就要登台演出了，老师说再唱一遍，满意小兰就可以回家了，不满意再练一般，满意为止（y/n);

            //string answer = "";
            //do
            //{
            //    Console.WriteLine("老师，我唱的您满意吗？y/n");
            //    answer = Console.ReadLine();
            //} while (answer != "y");

            //Console.WriteLine("Ok，老师很满意，可以回家了");
            //Console.ReadLine();
            #endregion

            #region 要求输入用户名和密码，只要不是admin、password就一直提示用户名或密码不正确，请重新输入

            //string uName = "";
            //string uPwd = "";

            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    uName = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码");
            //    uPwd = Console.ReadLine();
            //} while (uName != "admin" || uPwd != "password");

            //Console.WriteLine("恭喜您，登录成功，你的账号是{0},密码是{1}", uName, uPwd);
            //Console.ReadKey();

            #endregion

        }
    }
}

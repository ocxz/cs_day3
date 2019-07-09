using System;

namespace _03_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            #region if-else-if实现 工资评定，A-- > 涨500 B-- > 涨200 C-- > 不变  D-- > 降200 E-- > 降500 原工资5000 输入评级 输出来年工资
            //decimal salary = 5000m;
            //bool flag = true;
            //Console.WriteLine("请输入对李四的年终评定");   // A B C D E 乱七八糟
            //string level = Console.ReadLine();
            //if (level == "A")
            //{
            //    salary += 500;   // salary = salary + 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{
            //    salary += 0;
            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else   // 用户输错了 不是 A B C D E 其他一个
            //{
            //    Console.WriteLine("输入有误，程序退出");
            //    flag = false;
            //}

            //if (flag)
            //{
            //    Console.WriteLine("李四来年的工资时{0:0.00}元", salary);
            //}
            //Console.ReadKey(); 
            #endregion

            #region switch-case实现 工资评定，A-- > 涨500 B-- > 涨200 C-- > 不变  D-- > 降200 E-- > 降500 原工资5000 输入评级 输出来年工资
            //decimal salary = 5000m;
            //bool flag = true;
            //Console.WriteLine("请输入对李四的年终评定");   // A B C D E 乱七八糟
            //string level = Console.ReadLine();
            //switch (level)
            //{
            //    case "A":
            //        salary += 500;
            //        break;
            //    case "B":
            //        salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":
            //        salary -= 200;
            //        break;
            //    case "E":
            //        salary -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("输入有误，程序退出");
            //        flag = false;
            //        break;
            //}

            //if (flag)
            //{
            //    Console.WriteLine("李四来年的工资时{0:0.00}元", salary);
            //}
            //Console.ReadKey(); 
            #endregion

        }
    }
}

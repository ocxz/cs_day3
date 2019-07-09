using System;

namespace _04_switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 让用户输入姓名，然后显示出这个人上辈子是什么职业
            //Console.WriteLine("请输入你的姓名，我们将显示处理你上辈子的职业");
            //string name = Console.ReadLine();
            //// 老杨、老苏、老马、老蒋、老牛、老虎、老赵
            //switch (name)
            //{
            //    case "老杨":
            //        Console.WriteLine("上辈子是个抽大烟的");
            //        break;
            //    case "老苏":
            //        Console.WriteLine("上辈子是个老鸨子");
            //        break;
            //    case "老马":
            //        Console.WriteLine("上辈子是个老苏手上的头牌");
            //        break;
            //    case "老蒋":
            //        Console.WriteLine("上辈子是个拉长条的");
            //        break;
            //    case "老牛":
            //        Console.WriteLine("上辈子是个农民");
            //        break;
            //    case "老虎":
            //        Console.WriteLine("上辈子是个病猫子");
            //        break;
            //    case "老赵":
            //        Console.WriteLine("上辈子是个搓蛋");
            //        break;
            //    default:
            //        Console.WriteLine("不认识，无法判断");
            //        break;           
            //}

            //Console.ReadKey(); 
            #endregion

            #region switch-case 进行实现成绩评测  >=90-->A  >=80 B >=70 C >=60 D <60 E  思想：将区域变成值
            //Console.WriteLine("请输入一个考试成绩");    // 0-100
            //int score = Convert.ToInt32(Console.ReadLine());

            //switch (score / 10)     // 将范围便定值
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("E");
            //        break;
            //}

            //Console.ReadKey(); 
            #endregion

            #region switch-case引用flag标志控制，实现输入年份、月份输出该月天数
            //// switch-case实现输入年份、月份输出该月天数
            //// 1、3、5、7、8、10、12  -->31天
            //// 4、6、9、11 -->30天
            //// 2月 平年29天 闰年 28天
            //int year = 0;
            //int month = 0;
            //bool flag = true;
            //Console.WriteLine("请输入年份（1000-4000）之间的数");
            //try
            //{
            //    year = Convert.ToInt32(Console.ReadLine());   // 输入年份
            //    if (year < 1000 || year > 4000)             // 年份超出范围
            //    {
            //        Console.WriteLine("输入年限不正确，程序退出");
            //        flag = false;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("输入年份格式不正确，程序退出");   // 年份格式不正确
            //    flag = false;
            //}

            //if (flag)   // 若年份符合要求则判断月份
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入月份（1-12）之间的数");
            //        month = Convert.ToInt32(Console.ReadLine());   // 输入月份
            //        if (month < 1 || month > 12)                  // 判断月份是否在1-12月之间
            //        {
            //            Console.WriteLine("月份输入不正确，程序退出");
            //            flag = false;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入月份格式不正确，程序退出");   // 月份格式不正确
            //        flag = false;
            //    }

            //    if (flag)     // 如果年份和月份都符合要求，则进行switch-case月份判断
            //    {
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                Console.WriteLine("{0}年第{1}个月的天数为31天", year, month);  // 1、3、5、7、8、10、12  -->31天
            //                break;
            //            case 4:
            //            case 6:
            //            case 9:
            //            case 11:
            //                Console.WriteLine("{0}年第{1}个月的天数为30天", year, month);  // 4、6、9、11 -->30天
            //                break;
            //            case 2:
            //                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))   // 闰年判断
            //                {
            //                    Console.WriteLine("{0}年是闰年，其{1}月的天数只有28天", year, month);  // 闰年2月为28天
            //                }
            //                else
            //                {
            //                    Console.WriteLine("{0}年是平年，其{1}月的天数有29天", year, month);   // 平年2月为29天
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("月份输入不正确，程序退出");
            //                break;
            //        }
            //    }

            //}


            //Console.ReadKey(); 
            #endregion
            
            #region switch-case不引用flag标志控制，实现输入年份、月份输出该月天数
            //// switch-case实现输入年份、月份输出该月天数
            //// 1、3、5、7、8、10、12  -->31天
            //// 4、6、9、11 -->30天
            //// 2月 平年29天 闰年 28天
            //int year = 0;
            //int month = 0;
            //Console.WriteLine("请输入年份（1000-4000）之间的数");
            //try
            //{
            //    year = Convert.ToInt32(Console.ReadLine());   // 输入年份
            //    if (year < 1000 || year > 4000)             // 年份超出范围
            //    {
            //        Console.WriteLine("输入年限不正确，程序退出");
            //    }
            //    else   // 年份符合要求
            //    {
            //        Console.WriteLine("请输入月份（1-12）之间的数");
            //        try
            //        {
            //            month = Convert.ToInt32(Console.ReadLine());   // 输入月份
            //            if (month < 1 || month > 12)                  // 判断月份是否在1-12月之间
            //            {
            //                Console.WriteLine("月份输入不正确，程序退出");
            //            }
            //            else    // 月份符合要求
            //            {
            //                switch (month)
            //                {
            //                    case 1:
            //                    case 3:
            //                    case 5:
            //                    case 7:
            //                    case 8:
            //                    case 10:
            //                    case 12:
            //                        Console.WriteLine("{0}年第{1}个月的天数为31天", year, month);  // 1、3、5、7、8、10、12  -->31天
            //                        break;
            //                    case 4:
            //                    case 6:
            //                    case 9:
            //                    case 11:
            //                        Console.WriteLine("{0}年第{1}个月的天数为30天", year, month);  // 4、6、9、11 -->30天
            //                        break;
            //                    case 2:
            //                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))   // 闰年判断
            //                        {
            //                            Console.WriteLine("{0}年是闰年，其{1}月的天数只有28天", year, month);  // 闰年2月为28天
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("{0}年是平年，其{1}月的天数有29天", year, month);   // 平年2月为29天
            //                        }
            //                        break;
            //                    default:
            //                        Console.WriteLine("月份输入不正确，程序退出");
            //                        break;
            //                }
            //            }

            //        }
            //        catch  // 跟年份try配对
            //        {
            //            Console.WriteLine("输入月份格式不正确，程序退出");   // 月份格式不正确
            //        }
            //    }
            //}
            //catch   // 跟月份try配对
            //{
            //    Console.WriteLine("输入年份格式不正确，程序退出");   // 年份格式不正确
            //}
            
            //Console.ReadKey(); 
            #endregion
        }
    }
}

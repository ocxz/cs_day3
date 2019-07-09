using System;

namespace _07_while循环小练习
{
    class Program
    {
        static void Main(string[] args)
        {

            #region while循环结合break和try-catch实现输入班级人数，输入学员成绩，计算班级学员平均成绩和总成绩
            //// 输入班级人数，输入学员成绩，计算班级学员平均成绩和总成绩
            //Console.WriteLine("请输入你班级的人数");
            //int scoreSum = 0;   // 声明一个变量，用来存储总分
            //int stuCount = 0;  // 声明一个变量，用来存储班级人数
            //int i = 1;  // 控制变量

            //while (true)
            //{
            //    try
            //    {
            //        stuCount = Convert.ToInt32(Console.ReadLine());   // 键盘输入班级人数
            //        if (stuCount > 0 && stuCount <= 200)   // 判断输入班级人数是否处于0-200之间
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入班级人数错误，请重新输入");   // 班级人数超出范围
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入班级人数错误，请重新输入");   // 班级人数输入格式不正确
            //    }
            //}


            //while (i<=stuCount)
            //{
            //    Console.WriteLine("请输入第{0}个同学的成绩", i);    // 提示用户输入第i个同学的成绩
            //    while (true)
            //    {
            //        try
            //        {
            //            int stuScore = Convert.ToInt32(Console.ReadLine());   // 接收用户输入成绩
            //            if (scoreSum >= 0 && scoreSum <= 100)   // 判断输入成绩是否在0-100之间
            //            {
            //                scoreSum += stuScore;     // 将输入的成绩统计到总分里面
            //                i++;
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("第{0}个同学成绩输入错误，请重新输入", i);   // 输入成绩超出范围
            //            }
            //        }
            //        catch
            //        {
            //            Console.WriteLine("第{0}个同学成绩输入错误，请重新输入", i);   // 输入成绩格式不正确
            //        }
            //    }
            //}

            //Console.WriteLine("输入完成，班级总成绩是{0:0.0},平均成绩是{1:0.0}",scoreSum, scoreSum*1.0/stuCount);
            //Console.ReadKey(); 
            #endregion

            #region while循环结合break编程解决老师问题，会可以放学，不会，教，会放学，上次不会后放学
            //// 老师问题，会可以放学，不会，教，会放学，上次不会后放学
            //// 循环体：讲课、判断、提问、回答
            //// 循环条件：讲十次 i<=10、会了
            //// 循环变量 int i = 0;
            //int i = 0;    // 从不用讲开始

            //while (i <= 10)     // 判断讲的次数是否小于十次
            //{
            //    Console.WriteLine("同学们，这道题会了吗？y/n");
            //    string input = Console.ReadLine();
            //    if (input == "y")    // 判断学生是否听懂
            //    {
            //        Console.WriteLine("讲了{0}遍，会，可以放学了", i);
            //        break;    // 听懂了，放学，跳出循环
            //    }
            //    else   // 每听懂，判断是否超过十遍
            //    {
            //        if (i == 10)    // 如果讲道了第十遍，不讲了，放学
            //        {
            //            Console.WriteLine("讲了{0}遍，还没会，真是孺子不可教也，放学吧", i);
            //        }
            //        else    // 还没讲到第十遍，还可以讲
            //        {
            //            Console.WriteLine("讲了{0}遍，还没会，继续讲", i);  
            //        }
            //        i++;   // 讲题次数加一
            //    }
            //}

            //Console.ReadKey();
            #endregion

            #region while循环实现2006年培养学员80000人，每年增长25% 何年培训人数达到20万人
            //// 2006年培养学员80000人，每年增长25% 何年培训人数达到20万人
            //// 循环条件：学员达到20万人
            //// 循环体：每年增长25%

            //int years = 2006;
            //int stuCount = 80000;
            //while (stuCount < 200000)
            //{
            //    years++;
            //    stuCount = (int)(stuCount * 1.25);
            //}

            //Console.WriteLine("{0}年，培养的人数将达到{1}人", years, stuCount);
            //Console.ReadKey();
            #endregion

            #region while循环实现 提示用户输入yes或者no 若输入的不是，则一直要求用户输入
            //// 提示用户输入yes或者no 若输入的不是，则一直要求用户输入
            //// 循环体：提示用户输入，接收，判断
            //// 循环判断：用户输入的是否为yes或no

            //while (true)
            //{
            //    Console.WriteLine("请输入yes/no");
            //    string input = Console.ReadLine();
            //    if (input == "yes" || input == "no")
            //    {
            //        break;
            //    }
            //}
            //Console.ReadKey(); 
            #endregion

            #region 提示用户输入用户名和密码，用户名等于admin且密码等于password成功，否则重新输入，最多输入三次
            //// 提示用户输入用户名和密码，用户名等于admin且密码等于password成功，否则重新输入，最多输入三次
            //// 循环体：接收输入，判断是否成功
            //// 循环条件：最多输入三次
            //// 成功：跳出循环
            //// 超过三次：失败，跳出循环

            //int i = 1; // 第一次输入 记录循环次数
            //string userName = "";   // 用来接收用户输入的用户名
            //string userPwd;    // 用来接收用户输入的密码
            //while (i <= 3)   // 判断输入次数是否小于等于3次
            //{
            //    Console.WriteLine("您第{0}次输入用户名和密码",i);
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码");
            //    userPwd = Console.ReadLine();
            //    if (userName == "admin" && userPwd == "password")   // 判断输入用户名或密码是否正确
            //    {
            //        Console.WriteLine("恭喜您，登录成功，你一共输入了{0}次账号和密码", i);
            //        break;   // 正确，退出循环
            //    }else if (i == 3)   // 不正确，判断是否为第三次输错
            //    {
            //        Console.WriteLine("您已经输错了{0}次账号或密码，暂不能再次输入，程序退出", i);   // 第三次输错，则提示退出
            //    }
            //    i++;   // 输入次数加一
            //}
            //Console.ReadKey(); 
            #endregion

            #region 写两个循环，第一个循环提示用户A输入用户名，不能为空，否则一直输入  第二个循环提示用户B输入，不能为空或与A相同，否则一直输入
            //// 写两个循环，第一个循环提示用户A输入用户名，不能为空，否则一直输入  第二个循环提示用户B输入，不能为空或与A相同，否则一直输入
            //// 第一个循环
            //// 循环体：接收A用户输入的用户名
            //// 循环条件：A的用户名（aName)为空

            //// 第二个循环
            //// 循环体：接收B用户输入的用户名
            //// 循环条件：B的用户名（bName)为空或者与aName相同

            //string aName = "";
            //string bName = "";
            //Console.WriteLine("请输入A的用户名");
            //aName = Console.ReadLine();
            //while (aName == "")
            //{
            //    Console.WriteLine("A用户名不能为空，请重新输入");
            //    aName = Console.ReadLine();
            //}

            //Console.WriteLine("请输入B的用户名");
            //bName = Console.ReadLine();
            //while (bName == "" || bName == aName)
            //{
            //    if (bName == "")
            //    {
            //        Console.WriteLine("B的用户名不能为空，请重新输入");
            //        bName = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("B的用户名不能与A用户名一致，请重新输入");
            //        bName = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("A的用户名为{0}，B的用户名为{1}", aName, bName);
            //Console.ReadKey(); 
            #endregion
        }
    }
}

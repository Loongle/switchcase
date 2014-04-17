using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
        Top:
            Console.WriteLine("请输入一个月份:");
            int myMonth = int.Parse(Console.ReadLine());
            string mySeason;
            switch (myMonth)
            {
                case 12:
                case 1:
                case 2:
                    mySeason = "你输入的月份是春季!";
                    break;

                case 3:
                case 4:
                case 5:
                    mySeason = "你输入的月份是夏季!";
                    break;

                case 6:
                case 7:
                case 8:
                    mySeason = "你输入的月份是秋季!";
                    break;

                case 9:
                case 10:
                case 11:
                    mySeason = "你输入的月份是冬季";
                    break;

                default:
                    Console.WriteLine("你麻痹.输错了!\n");
                    
                    goto Top;
                    
            }
            Console.WriteLine(mySeason);
            Console.ReadLine();
                

                


        }
    }
}

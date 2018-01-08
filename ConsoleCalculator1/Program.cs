﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符（+、-、*、/）");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                        {
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        }
                        else
                        {
                            strResult = "除数不能为0";
                        }
                        break;
                }
                Console.WriteLine("结果是:" + strResult);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误:" + e.Message);
            }
        }
    }
}

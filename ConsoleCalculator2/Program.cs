using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A:");
                double strNumberA =Convert.ToDouble( Console.ReadLine());
                Console.Write("请选择运算符（+、-、*、/）");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B:");
                double strNumberB = Convert.ToDouble(Console.ReadLine());
                string strResult = Convert.ToString(Operation.GetResult(strNumberA, strNumberB, strOperate));
                Console.WriteLine("结果是: " + strResult);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误:" + e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字A:");
            string A = Console.ReadLine();
            Console.Write("请选择运算符（+ 、-、*、、）:");
            string B = Console.ReadLine();
            Console.Write("请输入数字B:");
            string C = Console.ReadLine();
            string result = "";

            if (B == "+")
            {
                result = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            }
            if (B == "-")
            {
                result = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            }
            if (B == "*")
            {
                result = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            }
            if (B == "/")
            {
                result = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            }

            Console.WriteLine("结果是: " + result);
        }
    }
}

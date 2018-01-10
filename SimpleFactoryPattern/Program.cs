using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("输入A：");
            //double numberA = Convert.ToDouble(Console.ReadLine());
            //Console.Write("选择运算符(+、-、*、/、) ：");
            //string strOper = Console.ReadLine();
            //Console.Write("输入B ：");
            //double numberB = Convert.ToDouble(Console.ReadLine());
            Operation oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            //Console.ReadLine();
        }
    }
}

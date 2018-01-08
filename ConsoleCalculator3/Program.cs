using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = OperationFactory.crateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GerResult();
        }
    }
}

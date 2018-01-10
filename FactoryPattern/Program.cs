using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFac = new AddFactory();
            Operation oper =  operFac.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 3;
            double result = 
                oper.GetResult();
        }
    }
}

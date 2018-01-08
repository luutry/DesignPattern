using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator3
{
    class Operation
    {
        private double _numberA;
        private double _numberB;

        public virtual double GerResult()
        {
            double result = 0;
            return result;
        }

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
    
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        } 
    }
}

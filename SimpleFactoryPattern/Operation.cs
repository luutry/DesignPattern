using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public abstract class Operation
    {
        private double _NumberA;

        private double _NumberB;

        public abstract double GetResult();
   
        public double NumberA
        {
            get { return _NumberA; }
            set { _NumberA = value; }
        }

        public double NumberB
        {
            get { return _NumberB; }
            set { _NumberB = value; }
        }
    }
}

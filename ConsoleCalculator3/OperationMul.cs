﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator3
{
    class OperationMul:Operation
    {
        public override double GerResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class OperationMub : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
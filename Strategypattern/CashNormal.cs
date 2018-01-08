using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypattern
{
    class CashNormal : CashSuper
    {
        public double acceptCash(double money)
        {
            return money;
        }
    }
}

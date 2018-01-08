using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypattern
{
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebat)
        {
            this.moneyRebate = double.Parse(moneyRebat);
        }

        public double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypattern
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string condition, string ret)
        {
            this.moneyCondition = double.Parse(condition);
            this.moneyReturn = double.Parse(ret);
        }

        public double acceptCash(double money)
        {
            double result = money;
            if (money > moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            return result;
        }
    }
}

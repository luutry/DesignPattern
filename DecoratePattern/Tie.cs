using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带 ");
        }
    }
}

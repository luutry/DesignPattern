using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person xc = new Person("小菜");
            //Console.WriteLine("\n 第一种装扮: ");
            //xc.WearBigTrouser();
            //xc.WearSuit();
            //xc.Show();

            //Console.WriteLine("\n 第二种装扮: ");
            //xc.WearBigTrouser();
            //xc.WearSuit();
            //xc.WearTie();
            //xc.Show();

            //Console.Read();

            Person1 p1 = new Person1("小菜");
            Console.WriteLine("\n 第一种装扮 : ");
            Finery dtx = new TShirts();
            Finery ld = new Tie();
            dtx.Show();
            ld.Show();
            p1.Show();
            Console.Read();
        }
    }
}

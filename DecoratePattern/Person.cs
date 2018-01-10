using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.Write("穿T恤");
        }
        public void WearBigTrouser()
        {
            Console.Write("垮裤");
        }
        public void WearSneakers()
        {
            Console.Write("破球鞋");
        }
        public void WearSuit()
        {
            Console.Write("西装");
        }
        public void WearTie()
        {
            Console.Write("领带");
        }

        public void WearShoes()
        {
            Console.Write("皮鞋");
        }

        public void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
}

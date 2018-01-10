using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Person1
    {
        private string name;
        public Person1(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("装扮的是{0}", name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        //    User user = new User();
        //    SqlserverUser su = new SqlserverUser();
        //    su.Insert(user);
        //    su.GetUser(1);
        //    Console.Read();

            User user = new User();
            IFactory factory = new SqlServerFactory();
            IUser iu = factory.createUser();
            iu.Insert(user);
            iu.GetUser(1);
            Console.Read();
        }
    }
}

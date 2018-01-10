using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access 中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access 中根据User的id得到User的一条记录");
            return null;
        }
    }
}

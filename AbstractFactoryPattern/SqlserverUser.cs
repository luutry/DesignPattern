using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
           

        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server 中根据User的id得到User的一条记录");
            return null;
        }
    }
}

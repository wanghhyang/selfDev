using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Unity
{
    public class UnitySetup
    {
        public static void Config(UnityContainer container)
        {
            container.RegisterType<ICustomerDataAccess, CustomerSqlDataAccess>();
            container.RegisterType<ICustomerDataAccess, CustomerMysqlDataAccess>("mysql");

        }
    }
}

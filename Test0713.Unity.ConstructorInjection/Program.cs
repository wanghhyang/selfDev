using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Unity.ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            UnitySetUp.Config<Customer>(container);
            var sqlCustomer = container.Resolve<Customer>();
            var myqlCustomer = container.Resolve<Customer>("mysqlCustomer");
            sqlCustomer.Save();
            myqlCustomer.Save();
            Console.ReadKey();
        }
    }
}

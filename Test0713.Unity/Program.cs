using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            var container =new  UnityContainer();
            UnitySetup.Config(container);
            Customer c = new Customer();
            c.CustomerDataAccess = container.Resolve<ICustomerDataAccess>("mysql");
            c.Save();
            //ICustomerDataAccess dataAccess = container.
            Console.ReadKey();
        }
    }
}

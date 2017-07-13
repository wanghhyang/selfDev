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
            Customer c = new Customer() { DbType="sql"};
            c.Save();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Unity
{
    public interface ICustomerDataAccess
    {
        void Save(Customer c);
    }

    public class CustomerSqlDataAccess : ICustomerDataAccess
    {
        public void Save(Customer c)
        {
            Console.Write("{2}, save data id:{0},name{1}", c.Id, c.Name, this.GetType().ToString());
        }
    }

    public class CustomerMysqlDataAccess : ICustomerDataAccess
    {
        public void Save(Customer c)
        {
            Console.Write("{2}, save data id:{0},name{1}", c.Id, c.Name, this.GetType().ToString());
        }
    }

    public class Customer
    {
        public ICustomerDataAccess CustomerDataAccess { get; set; }
        public string DbType { get; set; }
        public Customer()
        {
            if (DbType == "sql")
            {
                CustomerDataAccess = new CustomerSqlDataAccess();
            }
            else
            {
                CustomerDataAccess = new CustomerSqlDataAccess();
            }
        }
        public string Id { get; set; }
        public string Name { get; set; }

        public void Save()
        {
            CustomerDataAccess.Save(this);
        }
    }
}

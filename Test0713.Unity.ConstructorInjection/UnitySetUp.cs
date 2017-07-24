using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Unity.ConstructorInjection
{
    public class UnitySetUp
    {
        public static void Config<T>(IUnityContainer container)
        {
            #region 属性注入(Property Injection) http://www.cnblogs.com/slardar1978/p/4205394.html
            container.RegisterType<ICustomerDataAccess, CustomerSqlDataAccess>();
            container.RegisterType<ICustomerDataAccess, CustomerMysqlDataAccess>("mysql");
            #endregion
            #region 构造器注入(Constructor Injection)
            //container.RegisterType<T>(new InjectionConstructor(new ResolvedParameter<ICustomerDataAccess>()));
            //container.RegisterType<T>("mysqlCustomer", new InjectionConstructor(new ResolvedParameter<ICustomerDataAccess>("mysql")));
            #endregion
            #region  方法调用注入(Method Call Injection)
            container.RegisterType<T>("mysqlCustomer", new InjectionMethod("SetDataAccess", new ResolvedParameter<ICustomerDataAccess>("mysql")));
            #endregion
        }
    }
}

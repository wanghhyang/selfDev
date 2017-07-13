using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Console.Domain
{
    public interface IDomainObject<T>
    {
        T Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Console.Domain
{
    public class DomainObject<T>: IDomainObject<T>
    {
        private Guid guid;

        public DomainObject(Guid guid)
        {
            this.guid = guid;
        }

        public T Id { get; set; }
    }
}

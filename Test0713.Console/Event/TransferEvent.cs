using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Console.Event
{
    public class TransferEvent:DomainEvent
    {
        public Guid FromBankAccountId { get; set; }
        public Guid ToBankAccountId { get; set; }
        public double MoneyAmount { get; set; }
        public DateTime TransferDate { get; set; }
    }
}

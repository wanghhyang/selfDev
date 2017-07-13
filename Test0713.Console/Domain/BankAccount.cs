using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0713.Console.Domain
{
    public class BankAccount: DomainObject<Guid>
    {
        #region Constructors

        public BankAccount(Guid customerId) : base(Guid.NewGuid())
        {
            this.CustomerId = customerId;
        }

        #endregion

        #region Public Properties

        public Guid CustomerId { get; private set; }
        //[TrackingProperty]
        public double MoneyAmount { get; set; }

        #endregion

        #region Event Handlers

        //private void TransferTo(TransferEvent evnt)
        //{
        //    WithdrawMoney(evnt.MoneyAmount);

        //    CreateTransferHistory(evnt.FromBankAccountId,
        //                          evnt.FromBankAccountId,
        //                          evnt.ToBankAccountId,
        //                          evnt.MoneyAmount,
        //                          evnt.TransferDate);
        //}
        //private void TransferFrom(TransferEvent evnt)
        //{
        //    DepositMoney(evnt.MoneyAmount);

        //    CreateTransferHistory(evnt.ToBankAccountId,
        //                          evnt.FromBankAccountId,
        //                          evnt.ToBankAccountId,
        //                          evnt.MoneyAmount,
        //                          evnt.TransferDate);
        //}

        #endregion

        #region Private Methods

        private void WithdrawMoney(double moneyAmount)
        {
            if (this.MoneyAmount < moneyAmount)
            {
                throw new InvalidOperationException("账户余额不足。");
            }
            this.MoneyAmount -= moneyAmount;
        }
        private void DepositMoney(double moneyAmount)
        {
            this.MoneyAmount += moneyAmount;
        }
        //private void CreateTransferHistory(Guid currentBankAccount,
        //                                   Guid fromBankAccountId,
        //                                   Guid toBankAccountId,
        //                                   double moneyAmount,
        //                                   DateTime transferDate)
        //{
        //    TransferHistory transferHistory =
        //        new TransferHistory(
        //            fromBankAccountId,
        //            toBankAccountId,
        //            moneyAmount,
        //            transferDate);

        //    Repository.Add(transferHistory);

        //    EventProcesser.ProcessEvent(
        //        new AddAccountTransferHistoryEvent
        //        {
        //            BankAccountId = currentBankAccount,
        //            TransferHistory = transferHistory
        //        });
        //}

        #endregion
    }
}

using System;

namespace ATM.Domain.Interface
{
    public interface ITransaction
    {
        void InsertTransaction(long userBackAccountId, TransactionType transactionType, decimal transAmount, string desc);
        void ViewTransaction();
    }
}
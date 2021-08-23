using System;

namespace ATM.Domain.Entities
{
    public class Transaction
    {
        public long TranscationId { get; set; }
        public long UserBankAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Description { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}


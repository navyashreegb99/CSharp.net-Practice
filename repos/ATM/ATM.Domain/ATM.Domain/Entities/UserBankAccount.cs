using System;

namespace ATM.Domain.Entities
{
    public class UserBankAccount
    {
        public long Id { get; set; }
        public long CardNo { get; set; }
        public long CardPin { get; set; }

        public string FullName { get; set; }
        public long AccountNumber { get; set; }
        public long AccountBalance { get; set; }
        public int TotalLogin { get; set; }
        public bool IsLocked { get; set; }
    }
}


using System;

namespace ATM.Domain.Entities
{
	public enum Menu
    {
        CheckBalance=1,
        PlaceDeposit=2,
        MakeWithdrawl=3,
        ThirdPartyTransfer=4,
        ViewTransaction=5,
        Logout=6
    }
}

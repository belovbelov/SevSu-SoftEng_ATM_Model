using System;
using System.Threading;

namespace ATM.Operations
{
    public class Transfer : Operation
    {
        public int transferAmount;
        public BankAccount targetAccount;

        public override void ManipulateAccount(Card card, ATMData atmData)
        {
        return;
        }
    }
}
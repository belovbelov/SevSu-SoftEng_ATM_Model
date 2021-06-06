using System;

namespace ATM.Operations
{
    public class Deposit : Operation
    {
        private int depositAmount;
        public override void ManipulateAccount(Card card, ATMData atmData)
        {
            Console.Write("Operation: Insert deposit amount: ");
            depositAmount = Convert.ToInt32(Console.ReadLine());
            card.Account.Balance += depositAmount;
            atmData.Money += depositAmount;
        }

  
    }
}
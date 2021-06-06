using System;

namespace ATM.Operations
{
    public class Withdraw : Operation
    {
        private int withdrawAmount;
        public override void ManipulateAccount(Card card, ATMData atmData)
        {
            Console.Write("Insert withdraw amount: ");
            withdrawAmount = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (withdrawAmount > card.Account.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (withdrawAmount > atmData.Money)
                {
                    throw new ArgumentOutOfRangeException();
                }
                card.Account.Balance -= withdrawAmount;
                atmData.Money -= withdrawAmount;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }

        
    }
}
using System;

namespace ATM.Operations
{
    public class ChangePIN : Operation
    {
        private string newPIN;
        public override void ManipulateAccount(Card card, ATMData atmData)
        {
            ChangePin(card);
        }

        private void ChangePin(Card card)
        {
            Console.Write("Operation: Insert new PIN:");
            newPIN = Convert.ToString(Console.ReadLine());
            Bank.Instance.SavePIN(card,newPIN);
        }

        

    }
}
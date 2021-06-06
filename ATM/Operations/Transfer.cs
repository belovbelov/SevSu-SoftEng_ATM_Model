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
            Console.Write("Insert transfer amount: ");
            transferAmount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (transferAmount > card.Account.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                targetAccount = ChooseAccount();
                Console.WriteLine("Account to transfer: " + targetAccount.Id);
                Thread.Sleep(2000);
                card.Account.Balance -= transferAmount;
                targetAccount.Balance += transferAmount;
                atmData.Money += transferAmount;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }

        private BankAccount ChooseAccount()
        {
            //список аккаунтов
            return new BankAccount(new Client("Sasha"));
        }
    }
}
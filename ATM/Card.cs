using System;

namespace ATM
{
    public class Card
    {
        private Client owner;
        private BankAccount account;
        private int id;
        private string pin = "0000";

        public Card(BankAccount bankAccount, Client client)
        {
            account = bankAccount;
            owner = client;
        }
        
        public Card(BankAccount bankAccount, Client client,string _pin)
        {
            account = bankAccount;
            owner = client;
            pin = _pin;
        }

        public BankAccount Account => account;

        public string Pin
        {
            get => pin;
            set => pin = value;
        }
        public bool GrantAccess(string _pin)
        {
            if (!pin.Equals(_pin))
            {
                Console.WriteLine("Wrong PIN!");
                Console.ReadLine();
                return false;
            }
            return true;
        }
    }
}

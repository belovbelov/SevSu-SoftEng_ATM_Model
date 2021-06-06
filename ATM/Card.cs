using System;

namespace ATM
{
    public class Card
    {
        private Client owner;
        private BankAccount account;
        private int id;
        private string pin = "0000";
        public BankAccount Account => account;

        public string Pin
        {
            get => pin;
            set => pin = value;
        }
        public bool GrantAccess(string _pin)
        {
            return true;
        }
    }
}

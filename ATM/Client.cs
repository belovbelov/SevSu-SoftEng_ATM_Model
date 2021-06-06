using System;

namespace ATM
{
    public class Client
    {
        private int id;
        private string name;
        private int passport;

        public Client(string _name)
        {
            name = _name;
        }

        public BankAccount OwnAccount()
        {
            return new BankAccount(this);
        }

        private void OwnCard()
        {
            return;
        }
        public string InsertPIN()
        {
            var pin = Convert.ToString(Console.ReadLine());
            return pin;
        }
    }
}
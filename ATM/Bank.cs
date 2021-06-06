using System;
using System.Timers;

namespace ATM
{
    public class Bank
    {
        private static Bank instance = null;

        private Bank(){}
        public static Bank Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bank();
                }
                return instance;
            }
        }
        public string Address => "ул. Ленина 25";

        public bool SavePIN(Card card, string newPin)
        {
            card.Pin = newPin;
            return true;
        }
        public Card ControlCard(BankAccount _account, Client _client)
        {
            Console.WriteLine("Input your PIN");
            var pin = Convert.ToString(Console.ReadLine());
            return new Card(_account, _client, pin);
        }
        
        public Client ServiceClient(string _name)
        {
            return new Client(_name);
        }
        public ATMData ServiceATM()
        {
            return new ATMData();
        }
        public ATMData ServiceATM(string _address)
        {
            return new ATMData(_address);
        }

        public DateTime GetSecurity(ATMData atmData)
        {
            Console.WriteLine("BANK:   security to atm #" + atmData.Id);
            return DateTime.Now;
        }

    }
}
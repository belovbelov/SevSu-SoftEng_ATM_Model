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
    }
}
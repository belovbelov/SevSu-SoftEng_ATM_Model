using System;
using System.Threading;

namespace ATM
{
    public class MoneyCollection
    {
        private int currentMoney = 0;
        public void CollectMoney(ATMData atmData)
        {
            Console.WriteLine("Collecting money...");
            Thread.Sleep(5000);
            currentMoney = atmData.Money;
            atmData.Money = 0;
        }

        public void BringMoney(ATMData atmData)
        {
            Console.WriteLine("Bringing money...");
            Thread.Sleep(5000);
            atmData.Money = 10000;
        }
    }
}
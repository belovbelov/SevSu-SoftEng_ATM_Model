using System;

namespace ATM.Notifications
{
    public class MoneyLack : Notification
    {
        public override void Notificate(ATMData atmData)
        {
            Console.WriteLine("Notification: NOT ENOUGH MONEY");
            var collectors = new MoneyCollection();
            collectors.BringMoney(atmData);
        }
    } }
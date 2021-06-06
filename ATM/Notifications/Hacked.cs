using System;

namespace ATM.Notifications
{
    public class Hacked : Notification
    {
        public override void Notificate(ATMData atmData)
        {
            Console.WriteLine("Notification: Hack attempt was spotted! Call security?");
            Console.ReadLine();
            Console.WriteLine("Notification: Security is on their way!");
            Console.WriteLine(Bank.Instance.GetSecurity(atmData));
        }
    }
}
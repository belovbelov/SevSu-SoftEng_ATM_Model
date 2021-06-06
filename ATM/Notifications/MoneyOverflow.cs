namespace ATM.Notifications
{
    public class MoneyOverflow : Notification
    {
        public override void Notificate(ATMData atmData)
        {
            var collectors = new MoneyCollection();
            collectors.CollectMoney(atmData);
        }
    }
}
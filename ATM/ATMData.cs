using ATM.Notifications;
using ATM.Operations;

namespace ATM
{
    public class ATMData
    {
        private static int quantity = 0;
        private int id;
        private int moneyAmount = 10000;

        public ATMData()
        {
            id = ++quantity;
        }
        
        public ATMData(string _address)
        {
            Address = _address;
            id = ++quantity;
        }

        public int Id => id;
        public int Money
        {
            get => moneyAmount;
            set => moneyAmount = value;
        }
        public string Address { get;} = "Ул. Пушкина 1";

        public void SendNotification(Notification notification)
        {
            notification.Notificate(this);
        }

        public void InitiateOperation(Operation operation,Card card)
        {
            operation.ManipulateAccount(card,this);
        }
    }
}
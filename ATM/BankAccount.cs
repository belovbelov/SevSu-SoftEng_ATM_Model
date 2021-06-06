namespace ATM
{
    public class BankAccount
    {
        private static int id;
        private Client owner;
        private int balance = 1000;

        public BankAccount(Client client, int _balance)
        {
            owner = client;
            balance = _balance;
            id++;
        }
        
        public BankAccount(Client client)
        {
            owner = client;
            id++;
        }
        public int Balance
        {
            get => balance;
            set => balance = value;
        }
        
        public int Id => id;
        
        
    }
}
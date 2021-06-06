namespace ATM.Operations
{
    public abstract class Operation
    {
        protected Operation()
        {
            OperationCode++;
        }

        public static int OperationCode { get; protected set; }
        public abstract void ManipulateAccount(Card bankAccount, ATMData atmData);
    }
}
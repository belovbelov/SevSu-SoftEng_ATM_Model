using System;
using System.Threading;
using ATM.Notifications;
using ATM.Operations;
using Timer = System.Timers.Timer;

namespace ATM
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            int mode;
            Console.Clear();
            

            var atmData = Bank.Instance.ServiceATM("Ул. Пушкина");
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                    {

                            Console.Clear();
                            Console.Write("Input your name:");
                            var name = Convert.ToString(Console.ReadLine());
                            var client = Bank.Instance.ServiceClient(name);
                            var account = client.OwnAccount();
                            Console.Write("Input your balance:");
                            var balance = Convert.ToInt32(Console.ReadLine());
                            account.Balance = balance;
                            
                            var card = Bank.Instance.ControlCard(account, client);
                            Console.Clear();
                            Console.WriteLine("Press any button to insert the card");
                            Console.ReadLine();
                            Console.Clear();
                            Console.Write("Input your PIN-code: ");

                            var pin = client.InsertPIN();

                            Console.WriteLine("Checking...");
                            Thread.Sleep(1000);
                            if (!card.GrantAccess(pin))
                            {
                                return;
                            }

                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("1 Deposit");
                                Console.WriteLine("2 Withdraw");
                                Console.WriteLine("3 Transfer");
                                Console.WriteLine("4 Change PIN");
                                Console.WriteLine("5 View balance");
                                Console.WriteLine("6 Exit");
                                mode = Convert.ToInt32(Console.ReadLine());
                                if (mode == 6)
                                {
                                    break;
                                }

                                atmData.InitiateOperation(ChooseOperation(mode), card);
                            }

                            break;
                    }
                    case 2:
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("View notifications...");
                            Console.ReadKey();
                            Console.WriteLine("Choose type of notification:");
                            Console.WriteLine("1 Hacked");
                            Console.WriteLine("2 Lack of Money");
                            Console.WriteLine("3 Money Overflow");
                            Console.WriteLine("4 Exit");
                            mode = Convert.ToInt32(Console.ReadLine());
                            if (mode == 4)
                            {
                                break;
                            }
                            atmData.SendNotification(ChooseNotification(mode));
                        }

                        break;
                    }
                    case 3:
                        return;
                }
            }
        }

        private static Notification ChooseNotification(int mode)
        {
            switch (mode)
            {
                case 1:
                {
                    return new Hacked();
                }
                case 2:
                {
                    return new MoneyLack();
                }
                case 3:
                {
                    return new MoneyOverflow();
                }
                default:
                {
                    Console.WriteLine("Wrong type of notification!");
                    throw new NotSupportedException();
                }
            }
        }

        private static Operation ChooseOperation(int mode)
        {
            switch (mode)
            {
                case 1:
                {
                    return new Deposit();
                }
                case 2:
                {
                    return new Withdraw();
                }
                case 3:
                {
                    return new Transfer();
                }
                case 4:
                {
                return new ChangePIN();
                }
                case 5:
                {
                    return new BalanceViewer();
                }
                default:
                {
                    Console.WriteLine("Wrong operation!");
                    throw new NotSupportedException();
                }
            }
        }

        private static int Menu()
        {
            string[] menuButtons = {"1. User", "2. Manager", "3. Exit"};
            Console.Clear();
            Console.WriteLine("Select mode:");
            Console.WriteLine();
            foreach (var item in menuButtons)
            {
                Console.WriteLine(item);
            }
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    class BalanceViewer : Operation
    {
        public override void ManipulateAccount(Card card, ATMData atmData)
        {
            Console.WriteLine("Your balance: " + card.Account.Balance);
            Console.ReadLine();
        }
    }
}
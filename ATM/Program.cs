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
            
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                    {
                        break;
                    }
                    case 2:
                    {
                        break;
                           
                    } 
                    case 3:
                        return;
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
}
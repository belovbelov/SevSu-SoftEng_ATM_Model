using System;
using System.Collections.Generic;
using ATM;
using ATM.Operations;
using Xunit;

namespace ATM_Test
{
    public class OperationsTest
    {
        private Client client;
        private BankAccount account;
        private Card card;
        
        [Fact]
        public void DepositingMoney()
        {
            client = Bank.Instance.ServiceClient("Anton");
            account = client.OwnAccount();
            card = Bank.Instance.ControlCard(account, client);
            
            ATMData atmData = Bank.Instance.ServiceATM();
            var deposit = new Deposit();
            deposit.InputAmount(900);
            atmData.InitiateOperation(deposit, card);
            Assert.Equal(1900,account.Balance);
        }
        
        [Fact]
        public void WithdrawingMoney()
                 {
                     client = Bank.Instance.ServiceClient("Anton");
                     account = client.OwnAccount();
                     card = Bank.Instance.ControlCard(account, client);
                     ATMData atmData = Bank.Instance.ServiceATM();
                     var withdraw = new Withdraw();
                     withdraw.InputAmount(900);
                     atmData.InitiateOperation(withdraw, card);
                     Assert.Equal(100,account.Balance);
                 }
        
        [Fact]
        public void ChangingPin()
        {
            client = Bank.Instance.ServiceClient("Anton");
            account = client.OwnAccount();
            card = Bank.Instance.ControlCard(account, client);
            ATMData atmData = Bank.Instance.ServiceATM();

            var changePin = new ChangePIN();
                changePin.InputPin("1234");
            atmData.InitiateOperation(changePin, card);
            Assert.Equal("1234",card.Pin);
        }
    }
}
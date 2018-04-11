using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperAwesomeFancyPants.MsTest
{
    public class BankAccount
    {
        private string _name;
        private double _balance;
        public double Balance
        {
            get { return _balance; }
        }

        public BankAccount(string name, double beginningBalance)
        {
            _name = name;
            _balance = beginningBalance;
        }

        public void Debit(double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            _balance -= amount;
        }
    }

    [TestClass]
    public class CardTests
    {
        // unit test code  
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(debitAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        // unit test code  
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WithValidAmount_UpdatesBalanceException()
        {
            // arrange  
            double beginningBalance = 11.99;
            double debitAmount = 44.55;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Debit(debitAmount);
        }
    }
}

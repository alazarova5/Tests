using BackAccount;
using System;
using NUnit.Framework;

namespace BankAccountTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepositShouldIncreaseBalance()
        {
            BankAccount bankAccount = new BankAccount(123);
            bankAccount.Deposit(100);
            Assert.AreEqual(100, bankAccount.Balance);
        }

        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExceptions()
        {
            BankAccount bankAccount = new BankAccount(123);
            decimal depositAmount = -100;
            Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(depositAmount));
        }

        [Test]
        public void CreditShouldTakeMoneyFromBalane()
        {
            BankAccount bankAccount = new BankAccount(123);
            decimal cash = -100;
            bankAccount.Credit(cash);
            Assert.AreEqual(cash, bankAccount.Balance);
        }

        [Test]
        public void BalaneShouldIncreasePercent()
        {
            BankAccount bankAccount = new BankAccount(123);
            double percent = 30.0;
            bankAccount.Increase(percent);
            Assert.AreEqual(percent, bankAccount.Balance);
        }
    }
}
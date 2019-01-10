using System;
using Xunit;
using Lab_02_Unit_Testing;

namespace atmtest
{
    public class UnitTest1
    {
        [Fact]
        public void CanViewBalance()
        {
            Assert.True(Program.AddMoney(1.00));
        }

        [Fact]
        public void AddMoneyCorrect()
        {
            Program.Balance = 50;
            Program.AddMoney(45);
            Assert.Equal(95, Program.Balance);
        }

        [Fact]
        public void CannotWithdraw()
        {
            Program.Balance = 50;
            Withdraw.AddMoney(45);
            Assert.Equal(100, Program.Balance);
        }

        [Theory]
        [InlineData("Success"), 10.00]
    }
}

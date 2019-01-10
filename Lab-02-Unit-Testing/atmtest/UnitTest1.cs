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
        public void CanAddMoney()
        {
            Program.balance = 50;
            Program.AddMoney(45);
            Assert.Equal(95, Program.balance);
        }

        [Fact]
        public void CanWithdraw()
        {
            Program.balance = 50;
            Program.WithdrawMethod(10);
            Assert.Equal(40, Program.balance);
        }

        [Fact]
        public void CannotWithdraw()
        {
            Program.balance = 50;
            Program.AddMoney(-40);
            Assert.Equal(50, Program.balance);
        }
        public void 

        [Fact]

        [Theory]
        [InlineData("Success"), 10.00]
    }
}

using System;
using Xunit;
using Lab_02_Unit_Testing;

namespace atmtest
{
    public class UnitTest1
    {

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

        [Theory]
        [InlineData("Success", 10.00, 20.00)]
        [InlineData("Your are trying to withdraw an invalid amount", 0, 20)]
        [InlineData("Sorry you can't do that", 30, 20)]
        [InlineData("Success", 10.00, -100)]
    }
}

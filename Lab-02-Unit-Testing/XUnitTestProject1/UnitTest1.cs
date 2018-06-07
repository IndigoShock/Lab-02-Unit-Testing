using Lab_02_Unit_Testing;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnBalance()
        {
            Assert.Equal(1000, Program.AddDeposit(0));
        }

        [Theory]

        [InlineData(5, 1005)]
        [InlineData(100, 1105)]

        public void CanDepositProperly(decimal value, decimal expectedResult)
        {
            Assert.Equal(expectedResult, Program.AddDeposit(value));
        }

        [Theory]

        [InlineData(5, 2100)]
        [InlineData(-1000, 2105)]

        public void CanWithdrawProperly(decimal value, decimal expectedResults)
        {
            Assert.Equal(expectedResults, Program.AddWithdraw(value));
        }
    }
}

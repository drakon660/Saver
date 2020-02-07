using System;
using Xunit;

namespace Saver.Data.Tests
{
    public class InterestPaidTaxWayStrategyTests
    {
        private readonly InterestPaidTaxWayStrategy _standardInterestPaidStrategy = new InterestPaidTaxWayStrategy();

        [Theory]
        [InlineData(-1,0)]
        [InlineData(1001, 15.02)]
        [InlineData(823, 8.23)]
        [InlineData(60000, 1800)]
        [InlineData(5000, 75)]
        [InlineData(5001, 100.02)]
        [InlineData(10000, 200)]
        [InlineData(10001, 250.03)] // 250.025
        public void Calculate_Interest_Paid(decimal balance, decimal interestPaid)
        {
            decimal result = _standardInterestPaidStrategy.Calculate(balance);
            Assert.Equal(interestPaid, result);
        }
    }
}

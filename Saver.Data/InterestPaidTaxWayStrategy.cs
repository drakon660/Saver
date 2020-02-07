using Saver.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saver.Data
{
    public class InterestPaidTaxWayStrategy : IInterestPaidStrategy
    {
        public decimal Calculate(decimal balance)
        {
            if (balance < 0)
                return 0;

            if (balance <= 1000)
            {
                return Round((balance * 1) / 100);
            }
            else if (balance > 1000 && balance <= 5000)
            {
                return Round((balance * 15) / 1000);
            }

            else if (balance > 5000 && balance <= 10000)
            {
                return Round((balance * 20) / 1000);
                
            }
            else if (balance > 10000 && balance <= 50000)
            {
                return Round((balance * 25) / 1000);
                //return Round(balance * 0.025M);
            }
            else
            {
                return Round((balance * 30) / 1000);
                //return Round(balance * 0.030M);
            }
        }
        private decimal Round(decimal value)
        {
            return Math.Ceiling(value * 100) / 100;
            //return Math.Round(value, 2);
        }
    }
}

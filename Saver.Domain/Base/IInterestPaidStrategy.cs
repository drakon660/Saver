using System;
using System.Collections.Generic;
using System.Text;

namespace Saver.Domain.Base
{
    public interface IInterestPaidStrategy
    {
        decimal Calculate(decimal balance);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSoftware.Interfaces
{
    interface IAccount : IDepositable
    {
        ICustomer Customer { get; set; }
        decimal Balance { get;  }
        decimal InterestRate { get; }
        string CalculateInterest(int months);
    }
}

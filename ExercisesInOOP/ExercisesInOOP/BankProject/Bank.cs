using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Bank
    {
        public Bank()
        {
            Name = "bankName";
        }

        public Bank(string name)
        {
            Name=name;
        }
        public string Name { get; set; }
        public Customer MyCustomer { get; set; }
        public DepositAccount MyDepositAccount { get; set; }
        public LoanAccount loanAccount { get; set; }
        public MortgageAccount MortgageAccount { get; set; }
    }
}

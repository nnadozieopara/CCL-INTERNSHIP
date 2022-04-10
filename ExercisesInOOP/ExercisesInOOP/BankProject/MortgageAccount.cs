using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class MortgageAccount : BankAccount
    {
        public MortgageAccount()
        {

        }
        public override decimal CalculateInterestRate(int numberOfMonths, Customer customer)
        {
            if(customer is Company && numberOfMonths <= 12)
            {
                return numberOfMonths * InterestRate * 0.5m;
            }
            if (customer is Individual && numberOfMonths <= 6) return 0;
            return numberOfMonths * InterestRate;
        }
        
    }
}

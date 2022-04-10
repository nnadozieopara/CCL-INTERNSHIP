using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class LoanAccount : BankAccount
    {
        public LoanAccount()
        {

        }
        public override decimal CalculateInterestRate(int numberOfMonths, Customer customer)
        {
            if ((numberOfMonths <= 3 && customer is Individual) || (numberOfMonths <= 2 && customer is Company))
            {
                return 0;
            }
            else if (numberOfMonths > 4 && customer is Individual)
            {
                numberOfMonths -= 3;
                return numberOfMonths * InterestRate;
            }else if(numberOfMonths > 2 && customer is Company)
            {
                numberOfMonths -= 2;
                return numberOfMonths * InterestRate;
            }
            return 0;
        }
       
    }
}

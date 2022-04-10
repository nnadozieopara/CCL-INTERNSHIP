using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class DepositAccount: BankAccount,IWithdraw
    {
        public DepositAccount()
        {

        }
        public override decimal CalculateInterestRate(int numberOfMonths, Customer customer)
        {
            if(Balance >0 && Balance < 1000)
            {
                InterestRate = 0;
                return 0;
            }
            return numberOfMonths * InterestRate;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance <= 0)
            {
                Console.WriteLine("You have insufficient funds");
            }
            else
            {
                Balance -=amount;
                Console.WriteLine("=N={0} has been deducted to your account",amount);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public abstract class BankAccount:IDeposit
    {
        protected BankAccount()
        {
        }

        public virtual decimal CalculateInterestRate(int numberOfMonths, Customer customer)
        {
            return numberOfMonths*InterestRate;
        }

        public void DepositMoney(decimal amount)
        {
            Balance +=amount;
            Console.WriteLine("=N={0} has been added to your account",amount);
        }

        public Customer MyCustomer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
    }
}

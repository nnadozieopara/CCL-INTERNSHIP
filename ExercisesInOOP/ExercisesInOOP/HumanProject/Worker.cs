using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    public class Worker:Human,IComparable<Worker>
    {
        public Worker()
        {
            FirstName = "firstName";
            LastName = "lastName";
        }

        public Worker(decimal wage, int hoursWorked) : this()
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;
        }

        public decimal CalculateHourlyWage()
        {
            
            return (wage/hoursWorked);
        }

        public int CompareTo(Worker other)
        {
            if (other == null) return 1;
            return Wage.CompareTo(other.Wage);
        }

        public static bool operator >(Worker operand1, Worker operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        public static bool operator <(Worker operand1, Worker operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        public static bool operator >= (Worker operand1, Worker operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        public static bool operator <=(Worker operand1, Worker operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        private decimal wage;
        public decimal Wage 
        {
            get { return wage; }
            set { wage = value; } 
        }
        int hoursWorked;
        public int HoursWorked 
        { get { return hoursWorked; }
          set { hoursWorked = value; }
        }
    }
}

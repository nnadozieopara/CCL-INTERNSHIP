using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    public class Student:Human,IComparable<Student>
    {
        public Student(double mark)
        {
            Mark = mark;
        }
        public double Mark { get; set; }

        public int CompareTo(Student other)
        {
            if (other.Mark == 0) return 1;
            return Mark.CompareTo(other.Mark);
        }

        public static bool operator > (Student firstOperand, Student secondOperand)
        {
            return firstOperand.CompareTo(secondOperand) > 0;
        }
        public static bool operator < (Student firstOperand, Student secondOperand)
        {
            return firstOperand.CompareTo(secondOperand) < 0;
        }

        public static bool operator >= (Student firstOperand, Student secondOperand)
        {
            return firstOperand.CompareTo(secondOperand) >= 0;
        }

        public static bool operator <= (Student firstOperand, Student secondOperand)
        {
            return firstOperand.CompareTo(secondOperand) <= 0;
        }
    }
}

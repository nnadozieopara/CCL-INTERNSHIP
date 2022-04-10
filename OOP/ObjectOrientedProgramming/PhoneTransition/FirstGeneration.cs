using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition
{
    public class FirstGeneration:Phone
    {
        public FirstGeneration()
        {

        }
        public FirstGeneration(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public void Call()
        {
            Console.WriteLine("I can make calls");
        }

        public void Text()
        {
            Console.WriteLine("I can send text messages when I want");
        }
    }
}

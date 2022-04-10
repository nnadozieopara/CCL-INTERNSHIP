using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Individual:Customer
    {
        public Individual()
        {

        }
        public string NextOfKinName { get; set; }
        public string NextOfKinAddress { get; set; }
    }
}

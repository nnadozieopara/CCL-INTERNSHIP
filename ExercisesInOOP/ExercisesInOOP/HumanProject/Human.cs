﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    public abstract class Human
    {
        protected Human()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

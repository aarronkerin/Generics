﻿using Generics.Countable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Apple : ICountable
    {
        public string colour { get; set; }
        public int Count()
        {
            return 1;
        }
    }
}

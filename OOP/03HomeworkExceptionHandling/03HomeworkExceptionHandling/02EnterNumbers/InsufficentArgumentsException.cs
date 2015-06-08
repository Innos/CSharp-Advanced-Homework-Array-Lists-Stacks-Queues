using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    class InsufficentArgumentsException : ArgumentException
    {
        public InsufficentArgumentsException(string msg) : base(msg)
        {
        }
    }
}

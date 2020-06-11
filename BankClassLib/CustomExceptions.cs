using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankClassLib
{
    public class OverdraftException : Exception
    {
        public OverdraftException(string str) : base(str)
        {
        }
    }
}

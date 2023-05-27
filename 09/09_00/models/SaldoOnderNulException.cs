using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class SaldoOnderNulException : Exception
    {
        public SaldoOnderNulException() { }

        public SaldoOnderNulException(string message) : base(message) { }
    }
}

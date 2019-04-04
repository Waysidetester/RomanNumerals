using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class NumberTooLargeException : Exception
    {
        public NumberTooLargeException() : base("User entered number higher than planned for")
        {
        }
    }
}

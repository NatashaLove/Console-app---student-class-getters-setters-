using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_inclass02
{
    public class AgeBelowZeroException : Exception // custom class EXXTENDS exception
    {
        private static string _msg = "Age cannot be below zero.";

        public AgeBelowZeroException() : base(_msg) { } // this exception constructor CALLS base constructor message /
        // and the constructor must have a body - {}.
    }
}

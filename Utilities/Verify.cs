using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Diagnostics;
namespace Utilities
{
    public static class Verify
    {
        public static void Parameters(string s)
        { Debug.Assert(!String.IsNullOrEmpty(s)); }
        public static void Parameters(string s1, string s2)
        { Debug.Assert(!String.IsNullOrEmpty(s1) && !String.IsNullOrEmpty(s2)); }
        public static void Parameters(object o)
        { Debug.Assert(null != o); }
    }
}

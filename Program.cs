using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Day24_lamdaexp
{
    internal class Program
    {
        
        public static void Main()
        {
           
            Uc1_Regexfirstname pattern = new Uc1_Regexfirstname();
           
            pattern.Validate();
           
        }
    }
}
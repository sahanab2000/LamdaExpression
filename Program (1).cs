using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

namespace Lambdaexp_UC2
{
    class Lambdaexp_UC2
    {

        public string LastNameregexpattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public string lastname = "A";
        public void Validate()
        {
            Func<string, bool> result = (lastname) => Regex.IsMatch(lastname, "^[A-Z]{1}[A-Za-z]{2,}$");
            if (result(lastname))
            {
                Console.WriteLine("lastname  is valid");

            }
            else
            {
                Console.WriteLine("lastname  is invalid");

            }
        }
        public static void Main()
        {

            Lambdaexp_UC2 pattern = new Lambdaexp_UC2();

            pattern.Validate();

        }
    }

}



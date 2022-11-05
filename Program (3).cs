using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Day24_lamdaexp
{
    class Lambdaexp__UC4
    {


        public void Validate()
        {
            Console.WriteLine("Enter your 10 digit mobile number (ex:91-9119819801)");
            string mobile = Console.ReadLine();

            Func<string, bool> result = (mobile) => Regex.IsMatch(mobile, "^[0-9]{2,}[-][6-9][0-9]{9,}$");
            if (result(mobile))
            {
                Console.WriteLine("mobile no. is valid");

            }
            else
            {
                Console.WriteLine("mobile no. is invalid");

            }

        }
        public static void Main()
        {

            Lambdaexp__UC4 pattern = new Lambdaexp__UC4();

            pattern.Validate();

        }
    }

}



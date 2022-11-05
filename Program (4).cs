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
    class Lambdaexp__UC5
    {


        public void Validate()
        {
            Console.WriteLine("Enter your 8 digit password");
            string password = Console.ReadLine();

            Func<string, bool> result = (password) => Regex.IsMatch(password, "[A-Za-z1-9]{8}");
          
            if (result(password))
            {
                Console.WriteLine("password  is valid");

            }
            else
            {
                Console.WriteLine("password . is invalid");

            }

        }
        public static void Main()
        {

            Lambdaexp__UC5 pattern = new Lambdaexp__UC5();

            pattern.Validate();

        }
    }

}



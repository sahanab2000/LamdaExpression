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

namespace LambdaExpr_UC7
{
    class LambdaExp_UC7
    {


        public void Validate()
        {
            Console.WriteLine("Enter your 8 digit password");
            string password = Console.ReadLine();

            Func<string, bool> result = (password) => Regex.IsMatch(password, "(?=.*[A-Z])(?=.*[0-9a-z]).{7,}[0-9]");

            if (result(password))
            {
                Console.WriteLine("password  is valid");

            }
            else
            {
                Console.WriteLine("password  is invalid");

            }

        }
        public static void Main()
        {

            LambdaExp_UC7 pattern = new LambdaExp_UC7();

            pattern.Validate();

        }
    }

}



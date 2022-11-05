using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

namespace Day24_lamdaexp
{
    class Lambdaexp__UC3
    {

      
        public void Validate()
        {
            Console.WriteLine("Enter your mail ID");
            string Email = Console.ReadLine();
           
            Func<string, bool> result = (Email) => Regex.IsMatch(Email, "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$");
            if (result(Email))
            {
                Console.WriteLine("mail is valid");

            }
            else
            {
                Console.WriteLine("mail is invalid");

            }
            
        }
        public static void Main()
        {

            Lambdaexp__UC3 pattern = new Lambdaexp__UC3();

            pattern.Validate();

        }
    }

}



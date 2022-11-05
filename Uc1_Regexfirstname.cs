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
    class Uc1_Regexfirstname
    {

        public string FirstNameregexpattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public string firstname = "";
        public void Validate()
        {
            Func<string, bool> result = (firstname) => Regex.IsMatch(firstname, FirstNameregexpattern);
            Console.WriteLine(result(firstname));
        //    if (result(firstname))
        //    {
        //        Console.WriteLine("First name is valid");
             
        //    }
        //    else
        //    { Console.WriteLine("First name is invalid");

        //}
        }
    }
        
 }
  


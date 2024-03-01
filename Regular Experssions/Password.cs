using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
   public   class Password
    {
       public  Password()
        {
            string Partern = "^[A-Z][A-Z a-z 0-9 ]{4,}[^\\w\\s]{1,}$";
            Console.WriteLine("enter the password :");
            string Password = Console.ReadLine();
            Regex r = new Regex(Partern);
            if (r.IsMatch(Password))
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}

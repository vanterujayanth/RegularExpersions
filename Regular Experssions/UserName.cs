using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
   public  class UserName
    {
         String Format = "^[A-Z][a-z]{6,}$";
       public  UserName()
        {
            Console.WriteLine("enter the user name :");
            string UserName=Console.ReadLine();
            Regex r = new Regex(Format);
            if(r.IsMatch(UserName))
            {
                Console.WriteLine("valid");
            }
            else { Console.WriteLine("in valid"); }
        }

    }
}

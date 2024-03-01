using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
    public  class ForGmail
    {
        public ForGmail() 
        {
            Console.WriteLine("enter the mail id as input :  ");
            string Input= Console.ReadLine();
            Console.WriteLine("enter the  regular experssion :");
            string Pattern ="^[a-z 0-9]*[@][gmail|yahoo]$";
            Regex r=new Regex(Pattern);
           
            if (r.IsMatch(Input))
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

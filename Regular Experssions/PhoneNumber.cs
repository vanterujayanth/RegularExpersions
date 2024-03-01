using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
    public  class PhoneNumber
    {
        public PhoneNumber() 
        {
            Console.WriteLine("enter the phone number :");
            string PhoneNumber = Console.ReadLine();
            string Format = "^[//+][9][1][6789][0-9]{9}$";
            Regex r = new Regex(PhoneNumber);
            if(r.IsMatch(PhoneNumber))
            {
                Console.WriteLine(PhoneNumber);
            }
            else
            {
                Console.WriteLine("The entered input is not valid");
            }
        }
    }
}

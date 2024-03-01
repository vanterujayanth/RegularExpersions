using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
    public class FirstName
    {
        public void  First_Name() 
        {
            Console.WriteLine("enter the first name :");
            String FirstName = Console.ReadLine();
            String FormateForName = "^[A-Z][a-z]{2,}";
            Regex r = new Regex(FormateForName);
            if(r.IsMatch(FirstName))
            {
                Console.WriteLine(FirstName);
            }
            else
            {
                Console.WriteLine("it is not valid");
            }
        }
        public void Last_Name()
        {
            Console.WriteLine("enter the last name :");
            String LastName = Console.ReadLine();
            String FormateForName = "^[A-Z][a-z]{2,}";
            Regex r = new Regex(FormateForName);
            if (r.IsMatch(LastName))
            {
                Console.WriteLine(LastName);
            }
            else
            {
                Console.WriteLine("it is not valid");
            }
        }
        public void Gmail()
        {
            Console.WriteLine("enter the mail :");
            String Gmail = Console.ReadLine();
            String FormateForName = "^[a-z]{4,}.(.xyz).\b@bi.co.in\b$";
            Regex r = new Regex(FormateForName);
            if (r.IsMatch(Gmail))
            {
                Console.WriteLine(Gmail);
            }
            else
            {
                Console.WriteLine("it is not valid");
            }
        }

    }
}

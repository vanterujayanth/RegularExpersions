using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
    public class Remove_Data
    {
        public Remove_Data()
        {
            List<string> list = new List<string>()
             { "jay", "somesh", "loke", "r", "ramya", "ramu", "raju" ,"Somesh"};
            Console.WriteLine("enter the word you need to remove :");
            string patter = "^[A-Z a-z]{6}";
            Regex r =new Regex(patter);
            foreach(string s in list)
            {
                if(r.IsMatch(s))
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}

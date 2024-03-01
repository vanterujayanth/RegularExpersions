using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Experssions
{
    public  class UrlExtrection 
    {
        public void Url()
        {
            try
            {
                Console.WriteLine("enter the url :");
                string url = Console.ReadLine();
                string Fotmat = "^(https?://)?([/da-z.]+)[\\.com|\\.in|\\.org]$";
                    
                Regex r= new Regex(Fotmat);
                if(r.IsMatch(url))
                {
                    Console.WriteLine(url + "  is valid ");
                }
                else
                {
                    Console.WriteLine("in valid");
                }
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
           

        }
    }
}

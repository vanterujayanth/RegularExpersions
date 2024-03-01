using Regular_Experssions;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        UrlExtrection u2 = new UrlExtrection();
        u2.Url();
        ForGmail f1 = new ForGmail();    // for mail check
        Console.WriteLine("press enter :");
        Console.ReadLine();
        Password p2 = new Password();   //for password
        Console.WriteLine("press enter :");
        Console.ReadLine();
        UserName u1 = new UserName();   //for username
        Console.WriteLine("press enter :");
        Console.ReadLine();
        FirstName f2 = new FirstName();
        f2.First_Name(); // for firstname
        f2.Last_Name(); // for last name
        f2.Gmail();   // for spefied mail   (given by mam)
        Console.WriteLine("press enter :");
        Console.ReadLine();
        PhoneNumber p1 = new PhoneNumber();  // for phone number

        Remove_Data r1 = new Remove_Data();
    }
}
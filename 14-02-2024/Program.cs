// this is a testing program that includes some simply function
// an array of data (collection of data)
// and a bit of input from the user

using System;
using System.Net;

class Test { 
    // simple function which says welcome
    public static void welcome() {
        Console.WriteLine("Welcome");
    } // end welcome

    public static void signature() { 
        Console.WriteLine("-----wider---------");
    } // end signature

    //here is a function that takes a parameter //level 2
    public static void HaveANice(string name) { 
        Console.WriteLine("Have a nice day, " + name + "!");
    } // end have a nice function
    
    // this Main function is the entry-point in this file
    public static void Main(string[] args) { 
        Console.WriteLine("welcome is a user-defined function");
        Console.WriteLine("_______________________________");
        welcome(); 

        Console.WriteLine("\n");

        signature();

        string str1; 
        Console.Write("What is your name? "); 
        str1 = Console.ReadLine(); 
        HaveANice(str1);
    } // end Main
} // end class

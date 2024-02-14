// this is a testing program that includes some simply function
// an array of data (collection of data)
// and a bit of input from the user

using System;
using System.Reflection.Metadata.Ecma335;

class Test { 
    // simple function which says welcome
    public static void welcome() {
        Console.WriteLine("Welcome");
    } // end welcome
    
    // this Main function is the entry-point in this file
    public static void Main(string[] args) { 
        Console.WriteLine("welcome is a user-defined function");
        Console.WriteLine("_______________________________");
        welcome(); 

        Console.WriteLine("\n");
    } // end Main
} // end class

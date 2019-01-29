// Auther: Yanjun Yang
// Date: 1/28/2019
//Comments: This C# Console application code demostrates the use of methods.
using System;

namespace MethodDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");

            // Use try catch block to validate user input.
            try
            {
                string input = Console.ReadLine();
                // Call User_Name method.
                User_Name(input);
                                          
            }
            catch
            {
                Console.WriteLine("Please enter a valid user name.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }// end of catch
        }// end of main

        // This static void method shows the name user entered. 
        private static void User_Name(string get_name)
        {           
            Console.WriteLine("Hello" + " " + get_name + "!");
            Console.ReadKey(true);           
        }// end of User_Name
    }// end of class
}// end of namespace

/*
    Class ex
    Raul Flores
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // Single line comment
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();
        }

        private static void CSharpBasics()
        {
            string name;
            int hours = 8; //8L
            double payRate = 8.25; //8.25F
            int length = 10, width = 12;
            int aReallyLongIdentifierJustToSeeHowLongICanGo;
            char ch = 'X';
            bool result = true; //false
            //int counter;

            //Never!!!!

            //int a, b;            
            Console.WriteLine(hours);
            //name = "Sue";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //string message = "Hello " + name;
            string message = "Hello ";
            message += name;

            Console.WriteLine(message);
            //Console.Write("Hello ");
            //Console.WriteLine(name);
        }

        private static void NewGame ()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            //Console.WriteLine("Do you own this? ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/N)?");

            //Console.WriteLine("Price? ");
            //string price = Console.ReadLine();
            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");
        }

        private static void DisplayGame ()
        {
            string literall = "Hello Bob";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Owned? " + owned);
            Console.WriteLine("Completed? " + completed);            
        }

        private static bool ReadBoolean ( string message )
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            //Validate it is a boolean
            //HACK: Fix this expression
            if (result == "Y")
                return true;
            if (result == "y")
                return true;
            if (result == "n")
                return false;
            if (result == "N")
                return false;

            //TODO: Add validation
            return false;
        }

        //bool TryParse( string input, out decimal result );

        private static decimal ReadDecimal ( string message )
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            //decimal result;
            ///if (Decimal.TryParse(value, out result))            
            if (Decimal.TryParse(value, out decimal result))
                return result;

            return 0;
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}


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
            string literal1 = "Hello \"Bob\"";
            string path = "C:\\Windows\\System32";
            path += "\\Temp";
            string path2 = @"C:\Windows\System32";

            //1.string Concat
            Console.WriteLine("Name: " + name);

            //2. String format
            string str = String.Format("Price: {0:C}",price);  // :C is currency
            Console.WriteLine(str);
            // Console.WriteLine("Price: " + price);

            //3. Function overload- this one just calls string format
            Console.WriteLine("Publisher: {0} ", publisher);

            //4. Concatenation
            str =String.Concat("Owned?", " ", owned);
            Console.WriteLine(str);
            //Console.WriteLine("Owned? " + owned);

            //5.Interpolation- combo of string format with concat
            //Console.WriteLine("Completed? " + completed);            
            //Console.WriteLine("Completed? {0}", completed);
            Console.WriteLine($"Completed? {completed}");

            //Convert to a string
            string strPrice = price.ToString("C");// format specifier currency
            string strLiteral = "Hello".ToString(); // you can convert string to string
            10.ToString(); // "10"  

            //Is string empty
            string input = ""; 
            int length = input.Length;
            bool isEmpty;

            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;
            isEmpty = (input != null) ? input.Length == 0 : true;

            isEmpty = input.Length == 0; // comparing against 0
            isEmpty = input == "";// comparing against empty string
            isEmpty = input == String.Empty;  // comparing if empty by using string.empty

            isEmpty = String.IsNullOrEmpty(input);   // most used


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


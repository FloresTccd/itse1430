﻿/*
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
            var literal1 = "Hello \"Bob\"";
            var path = "C:\\Windows\\System32";
            path += "\\Temp";
            var path2 = @"C:\Windows\System32";

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
           // int length = input.Length;
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

            //Comparison
            bool areEqual = "Hello" == "hello";  // false cuase case sensitive
            areEqual = String.Compare("Hello","hello", true) == 0;       // mostly used. true 

            //Conversion
            input = input.ToUpper();
            input = input.ToLower();

            //Manipulation
            bool startsWith = input.StartsWith("http:"); //useful for pacing return boolean
            bool endsWith = input.EndsWith("/"); // useful for parcing return boolen

            input = input.TrimStart();
            input = input.TrimEnd();
            input = input.Trim();   //^^ to trim, default is white space, but can be used for specific

            input = input.PadLeft(10);
            input = input.PadRight(10);








        }

        private static bool ReadBoolean ( string message )
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper();
                
                //Validate it is a boolean
                if (result == "Y")
                    return true;
                if (result == "N")
                    return false;

             
                 //switch (result)
                //{
                //    case "Y":
                //    case "y": return true;

                //    case "N": 
                //    case "n": return false;

                //    default: Console.WriteLine("Enter Y or N"); break;
                //};

                
                //if (result == "y")
                //  return true;
                //if (result == "n")
                //  return false;

                Console.WriteLine("Enter Y or N");
            } while (true);
                
        }

        //bool TryParse( string input, out decimal result );

        private static decimal ReadDecimal ( string message )
        {
            while (true) // loops until a decimal is coded
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

            
                 //decimal result;
                 ///if (Decimal.TryParse(value, out result))            
                 if (Decimal.TryParse(value, out decimal result))
                    return result;

                Console.WriteLine("Enter a valid decimal value");
            };
           
        }

        private static void PlayWithArrays()
        {
            //int size = 100; // dont need it use .length
            int[] prices = new int[100];
            for (var index = 0; index < prices.Length; ++index)
            {
                prices[index] = index + 1;
            };

            DisplayArray(prices);

            var input = "field1, field2, field3;field4";
            var field = input.Split(',',';');
        }
        private static void DisplayArray( int[] values/*, int count*/ )
        {
            //for (var index = 0; index < values.Length; ++index)
            foreach (var item in values)
            {
                //Console.WriteLine(values[index]);
                Console.WriteLine(item);
            };
        }


        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }

   
}


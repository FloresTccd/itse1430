/*
    Lab 1
    Raul Flores
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            DisplayMenuOne();
            var menuOneChoice = Console.ReadLine();

            while (menuOneChoice != "4")
            {
                switch (menuOneChoice)
                {
                    case "1":
                        NewOrder(); 
                        break;
                    case "2":
                        ModifyOrder();
                        break;
                    case "3":
                        DisplayOrder();
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            DisplayMenuOne();
                            break;
                        }
                }
                menuOneChoice = Console.ReadLine();

            }// end of while loop

            
            
        }//end of main

        private static void NewOrder()
        {
            throw new NotImplementedException();
        }

        private static void ModifyOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplayOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenuOne()
        {
            Console.WriteLine("Tccd Pizza");
            Console.WriteLine("----------");
            Console.WriteLine("1.New Order");
            Console.WriteLine("2.Modify Order");
            Console.WriteLine("3.Display Order");
            Console.WriteLine("4.Quit");

        }






    }

}

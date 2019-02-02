/*
    Lab 1 ITSE1430
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
        private static decimal total = 0;

        static void Main( string[] args )
        {
            
            HandleMenuOneChoice();



        }//end of main

        private static void NewOrder()
        {
            decimal sizeOfPizza = SizeOfPizza();
            total += sizeOfPizza;


            //RedoOrder("Would you like to start a new Order?Y/N");
        }

        private static decimal SizeOfPizza()
        {
           
            
            while (true)
            {
                Console.WriteLine("What size Pizza?\n S=Small \n M=Medium \n L=Large");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "S":
                    return 5.00M;
                    case "M":
                    return 6.25M;
                    case "L":
                    return 8.75M;
                    default:
                    Console.WriteLine("Please pick S,M,L.");
                    break;

                }
            }
        }

        private static void ModifyOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplayOrder()
        {
            throw new NotImplementedException();
        }

        private static void HandleMenuOneChoice()
        {

            bool userQuit = false;

            while (!userQuit)
            {
                DisplayMenuOne();
                var menuOneChoice = Console.ReadLine();
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
                    case "4":
                    userQuit = true;
                    break;

                    default:
                        {
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                }



            }// end of while loop
        }

        private static void DisplayMenuOne()
        {
            Console.WriteLine("Tccd Pizza");
           
            string cartString = String.Format(" ---------- \t\t\t CART:{0:C}", total);
            Console.WriteLine(cartString);
            Console.WriteLine("1.New Order");
            Console.WriteLine("2.Modify Order");
            Console.WriteLine("3.Display Order");
            Console.WriteLine("4.Quit");

        }
        //private static void RedoOrder(string message)
        //{
        //    do
        //    {
        //        Console.WriteLine(message);
        //        string result = Console.ReadLine().ToUpper();

        //        //Validate it is a boolean
        //        if (result == "Y")
        //            DisplayMenuOne();

        //        if (result == "N")


        //        Console.WriteLine("Enter Y or N");
        //    } while (true);
        //}





    }

}

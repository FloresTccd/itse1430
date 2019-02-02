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
        private static string selectedItemUi = "[X]";
        private static string unselectedItemUi = "[ ]";

        static void Main( string[] args )
        {

            HandleMenuOneChoice();



        }//end of main

        private static void NewOrder()
        {
           
            total += SizeOfPizza();
            total += Meats();
            total += Vegetables();


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
        private static decimal Meats()
        {
            decimal totalMeats = 0;
            bool meatDone = false;
            bool baconSelected = false;
            bool hamSelected = false;
            bool pepperoniSelected = false;
            bool sausageSelected = false;

            while (!meatDone)
            {
                Console.WriteLine("What kinda of Meats? $0.75each \n");
                DisplaySelectedOption("B = Bacon", baconSelected);
                DisplaySelectedOption("H = Ham", hamSelected);
                DisplaySelectedOption("P = Pepperoni", pepperoniSelected);
                DisplaySelectedOption("S = Sausage", sausageSelected);
                Console.WriteLine("D = Done");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "B":
                    baconSelected = !baconSelected;
                    break;
                    case "H":
                    hamSelected = !hamSelected;
                    break;
                    case "P":
                    pepperoniSelected = !pepperoniSelected;
                    break;
                    case "S":
                    sausageSelected = !sausageSelected;
                    break;
                    case "D":
                    meatDone = true;
                    break;
                    default:
                    Console.WriteLine("Press select from Menu Only");
                    break;

                }
            }
            totalMeats += baconSelected ? .75M : 0;
            totalMeats += hamSelected ? .75M : 0;
            totalMeats += pepperoniSelected ? .75M : 0;
            totalMeats += sausageSelected ? .75M : 0;



            return totalMeats;
        }

        private static decimal Vegetables()
        {
            decimal totalVeggies = 0;
            bool veggieDone = false;
            bool oliveSelected = false;
            bool mushroomsSelected = false;
            bool onionsSelected = false;
            bool peppersSelected = false;

            while (!veggieDone)
            {
                Console.WriteLine("What kinda of Vegetables? $0.50each \n");
                DisplaySelectedOption("B = Black Olives", oliveSelected);
                DisplaySelectedOption("M = Mushrooms", mushroomsSelected);
                DisplaySelectedOption("O = Onions", onionsSelected);
                DisplaySelectedOption("P = Peppers", peppersSelected);
                Console.WriteLine("D = Done");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "B":
                    oliveSelected = !oliveSelected;
                    break;
                    case "M":
                    mushroomsSelected = !mushroomsSelected;
                    break;
                    case "O":
                    onionsSelected = !onionsSelected;
                    break;
                    case "P":
                    peppersSelected = !peppersSelected;
                    break;
                    case "D":
                    veggieDone = true;
                    break;
                    default:
                    Console.WriteLine("Press select from Menu Only");
                    break;

                }
            }
            totalVeggies += oliveSelected ? .50M : 0;
            totalVeggies += mushroomsSelected ? .50M : 0;
            totalVeggies += onionsSelected ? .50M : 0;
            totalVeggies += peppersSelected ? .50M : 0;



            return totalVeggies;
        }

        private static void ModifyOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplayOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplaySelectedOption( string option, bool hasOption )
        {
            Console.WriteLine(option + (hasOption ? selectedItemUi : unselectedItemUi));
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

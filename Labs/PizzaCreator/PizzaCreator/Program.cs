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
        private static bool isOrderInProgress = false;
        private static decimal total = 0;
        private static string selectedItemUi = "[X]";
        private static string unselectedItemUi = "[ ]";

        private static bool baconSelected = false;
        private static bool hamSelected = false;
        private static bool pepperoniSelected = false;
        private static bool sausageSelected = false;


        private static string pizzaChoice;
        private static string sauceChoice;
        private static string deliveryChoice;
        private static string cheeseChoice;

        private static bool oliveSelected = false;
        private static bool mushroomsSelected = false;
        private static bool onionsSelected = false;
        private static bool peppersSelected = false;

        private static decimal pricePerMeat = .75M;
        private static decimal pricePerVeggie = .50M;






        static void Main( string[] args )
        {

            HandleMenuOneChoice();



        }//end of main

        private static void NewOrder()
        {
            if (isOrderInProgress)
            {
                Console.WriteLine("Order in Progress \n Start Over? (Y/N)");
                string result = Console.ReadLine().ToUpper();
                if (result == "Y")
                {
                    isOrderInProgress = false;

                }
            }

            if (!isOrderInProgress)
            {
                StartOrder();
            }
            
        }

        private static void StartOrder()
        {
            isOrderInProgress = true;
            SizeOfPizza();
            Meats();
            Vegetables();
            Sauce();
            Cheese();
            Delivery();
            


            total += CalculateTotal();
            DisplayOrder();
        }


        private static void SizeOfPizza()
        {
            bool selectedOne = false;
            while (!selectedOne)
            {
                Console.WriteLine("What size Pizza?\n");
                DisplaySelectedOption("S = Small", pizzaChoice == "S");
                DisplaySelectedOption("M = Medium", pizzaChoice == "M");
                DisplaySelectedOption("L = Large", pizzaChoice == "L");
                string result = Console.ReadLine().ToUpper();

                switch (result)
                {
                    case "S":
                    pizzaChoice = "S";
                    selectedOne = true;
                    break;
                    case "M":
                    pizzaChoice = "M";
                    selectedOne = true;
                    break;
                    case "L":
                    pizzaChoice = "L";
                    selectedOne = true;
                    break;
                    default:
                    Console.WriteLine("Please pick S,M,L.");
                    break;

                }
            }
        }


        private static void Meats()
        {
            bool meatDone = false;

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
        }

        private static void Vegetables()
        {
            bool veggieDone = false;

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
        }

        private static void Sauce()
        {

            bool selectedOne = false;
            while (!selectedOne)
            {
                Console.WriteLine("What type of Sauce? \n T= Traditional \n G = Garlic \n O= Oregano \n");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "T":
                    selectedOne = true;
                    sauceChoice = "T";
                    break;
                    case "G":
                    sauceChoice = "G";
                    selectedOne = true;
                    break;
                    case "O":
                    sauceChoice = "O";
                    selectedOne = true;
                    break;
                    default:
                    Console.WriteLine("Please pick from menu");
                    break;

                }
            }
        }

        private static void Cheese()
        {
            bool selectedOne = false;
            while (!selectedOne)
            {
                Console.WriteLine("What type of Cheese?\n R = Regular \n E = Extra \n");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "R":
                    selectedOne = true;
                    cheeseChoice = "R";
                    break;
                    case "E":
                    selectedOne = true;
                    cheeseChoice = "E";
                    break;
                    default:
                    Console.WriteLine("Please pick from menu");
                    break;

                }
            }
        }

        private static void Delivery()
        {
            bool selectedOne = false;
            while (!selectedOne)
            {
                Console.WriteLine("Is this Take out or Delivery?\n T = Take Out \n D = Delivery \n");
                string result = Console.ReadLine().ToUpper();
                switch (result)
                {
                    case "T":
                    deliveryChoice = "T";
                    selectedOne = true;
                    break;
                    case "D":
                    deliveryChoice = "D";
                    selectedOne = true;
                    break;
                    default:
                    Console.WriteLine("Please pick from menu");
                    break;

                }
            }
        }

        private static void ModifyOrder()
        {
            if(isOrderInProgress)
            {
                StartOrder();
                
            } else
            {
                Console.WriteLine("Err order not in progress");
            }
        }

        private static void DisplayOrder()
        {
            switch (pizzaChoice)
            {
                case "S":
                Console.WriteLine("Small Pizza \t\t\t " + CalculateSizeOfPizzaTotal());
                break;
                case "M":
                Console.WriteLine("Medium Pizza \t\t\t 0.00");
                break;
                case "L":
                Console.WriteLine("Large Pizza \t\t\t 0.0.0");
                break;
            }

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

        private static decimal CalculateTotal()
        {
            decimal total = 0;
            total += CalculateSizeOfPizzaTotal();
            total += CalculateMeatTotal();
            total += CalculateVeggiesTotal();
            total += CalculateSauceTotal();
            total += CalculateCheeseTotal();
            total += CalculateDeliveryTotal();

            return total;
        }

        private static decimal CalculateSizeOfPizzaTotal()
        {
            switch (pizzaChoice)
            {
                case "S":
                return 5.00M;
                case "M":
                return 6.25M;
                case "L":
                return 8.75M;
                default:
                return 0;
            }
        }

        private static decimal CalculateSauceTotal()
        {
            switch (sauceChoice)
            {
                case "T":
                return 0;
                case "G":
                return 1;
                case "O":
                return 1;
                default:
                return 0;
            }
        }

        private static decimal CalculateCheeseTotal()
        {
            switch (cheeseChoice)
            {
                case "R":
                return 0;
                case "E":
                return 1.25M;
                default:
                return 0;
            }
        }

        private static decimal CalculateDeliveryTotal()
        {
            switch (deliveryChoice)
            {
                case "T":
                return 0;
                case "D":
                return 2.50M;
                default:
                return 0;
            }
        }

        private static decimal CalculateMeatTotal()
        {
            decimal total = 0;
            total += baconSelected ? pricePerMeat : 0;
            total += hamSelected ? pricePerMeat : 0;
            total += pepperoniSelected ? pricePerMeat : 0;
            total += sausageSelected ? pricePerMeat : 0;

            return total;
        }

        private static decimal CalculateVeggiesTotal()
        {
            decimal totalVeggies = 0;
            totalVeggies += oliveSelected ? pricePerVeggie : 0;
            totalVeggies += mushroomsSelected ? pricePerVeggie : 0;
            totalVeggies += onionsSelected ? pricePerVeggie : 0;
            totalVeggies += peppersSelected ? pricePerVeggie : 0;
            return totalVeggies;
        }

    }


}

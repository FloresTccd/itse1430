/*
    Lab 1 ITSE1430
    Raul Flores
    Feb 11, 2019

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

        private static void NewOrder()
        {
            if (isOrderInProgress)
            {
                Console.WriteLine("Order in Progress \n Start Over? (Y/N)");
                string result = Console.ReadLine().ToUpper();
                if (result == "Y")
                {

                    ResetOrder();

                }
            }

            if (!isOrderInProgress)
            {
                StartOrder();
            }

        }

        private static void ResetOrder()
        {
            isOrderInProgress = false;
            baconSelected = false;
            hamSelected = false;
            pepperoniSelected = false;
            sausageSelected = false;
            pizzaChoice = "";
            sauceChoice = "";
            deliveryChoice = "";
            cheeseChoice = "";
            oliveSelected = false;
            mushroomsSelected = false;
            onionsSelected = false;
            peppersSelected = false;
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
                Console.WriteLine("What kinda of Meats? $"+ pricePerMeat + " Pick one at a time \n");
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
                Console.WriteLine("What kinda of Vegetables? $"+ pricePerVeggie+" Pick one at a time \n");
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

                Console.WriteLine("What type of Sauce?\n");
                DisplaySelectedOption("T = Traditional", sauceChoice == "T");
                DisplaySelectedOption("G = Garlic", sauceChoice == "G");
                DisplaySelectedOption("O = Oregano", sauceChoice == "O");
                string sauceResult = Console.ReadLine().ToUpper();

                switch (sauceResult)
                {
                    case "T":
                    sauceChoice = "T";
                    selectedOne = true;
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
                Console.WriteLine("What type of Cheese?\n");
                DisplaySelectedOption("R = Regular", cheeseChoice == "R");
                DisplaySelectedOption("E = Extra", cheeseChoice == "E");
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
                Console.WriteLine("Is this Take Out or Delivery?\n");
                DisplaySelectedOption("T = Take Out", deliveryChoice == "T");
                DisplaySelectedOption("D = Delivery", deliveryChoice == "D");
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
            if (isOrderInProgress)
            {
                StartOrder();

            } else
            {
                Console.WriteLine("Err order not in progress");
            }
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tCurrent Order");
            switch (pizzaChoice)
            {
                case "S":
                Console.WriteLine("Small Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                break;
                case "M":
                Console.WriteLine("Medium Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                break;
                case "L":
                Console.WriteLine("Large Pizza \t\t\t$" + CalculateSizeOfPizzaTotal());
                break;
            }
            switch (deliveryChoice)
            {
                case "T":
                Console.WriteLine("Take Out ");
                break;
                case "D":
                Console.WriteLine("Delivery \t\t\t$" + CalculateDeliveryTotal());
                break;
            }
            Console.WriteLine("Meats");
            if (baconSelected)
            {
                Console.WriteLine("\t Bacon\t\t\t$" + pricePerMeat);
            }
            if (hamSelected)
            {
                Console.WriteLine("\t Ham\t\t\t$" + pricePerMeat);
            }
            if (pepperoniSelected)
            {
                Console.WriteLine("\t Pepperoni\t\t$" + pricePerMeat);
            }
            if (sausageSelected)
            {
                Console.WriteLine("\t Sausage\t\t$" + pricePerMeat);
            }

            Console.WriteLine("Vegetables");
            if (oliveSelected)
            {
                Console.WriteLine("\t Black Olives\t\t$" + pricePerVeggie);
            }
            if (mushroomsSelected)
            {
                Console.WriteLine("\t Mushrooms\t\t$" + pricePerVeggie);
            }
            if (onionsSelected)
            {
                Console.WriteLine("\t Onions\t\t\t$" + pricePerVeggie);
            }
            if (peppersSelected)
            {
                Console.WriteLine("\t Peppers\t\t$" + pricePerVeggie);
            }

            switch (cheeseChoice)
            {
                case "R":
                Console.WriteLine("Regular Cheese \t\t\t");
                break;
                case "E":
                Console.WriteLine("Extra Cheese \t\t\t$" + CalculateCheeseTotal());
                break;
            }
            Console.WriteLine("Sauce");
            switch (sauceChoice)
            {
                case "T":
                Console.WriteLine("\t Traditional \t\t$" + CalculateSauceTotal());
                break;
                case "G":
                Console.WriteLine("\t Garlic \t\t$" + CalculateSauceTotal());
                break;
                case "O":
                Console.WriteLine("\t Oregano \t\t$" + CalculateSauceTotal());
                break;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Total \t\t\t\t$" + total);
            Console.WriteLine("\n\n");

        }

        private static void DisplaySelectedOption( string displayLabel, bool hasOption )
        {
            Console.WriteLine(displayLabel + (hasOption ? selectedItemUi : unselectedItemUi));
        }

        private static void DisplayMenuOne()
        {
            Console.WriteLine("Tccd Pizza");

            string cartString = String.Format(" -----------------------------\t |CART:{0:C}|", total);
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

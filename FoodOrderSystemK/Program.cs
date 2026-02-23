using System;
using FoodOrderingSystem.Service;
using FoodOrderingSystem.Helpers;
using FoodOrder_Library.Models;
using FoodOrder_Library.Utilities;
using FoodOrder_Library.Enums;

namespace FoodOrderingSystem
{
    class Program
    {
        public static int TotalOrders = 0;

        static void Main()
        {
            Console.WriteLine("Welcome to " + Constants.RestaurantName);

            OrderManager order = new OrderManager();
            bool ordering = true;

            while (ordering)
            {
                Console.WriteLine("\nSelect Category:");
                Console.WriteLine("1. Veg");
                Console.WriteLine("2. Non-Veg");
                Console.WriteLine("3. Bill");

                int category = InputHelper.GetNumber();

                if (category == 3)
                {
                    if (order.CalculateTotal() == 0)
                    {
                        Console.WriteLine("No items ordered. Please order at least one item.");
                        continue;
                    }
                    ordering = false;
                    break;
                }

                FoodItem item = null;

                if (category == (int)FoodCategory.Veg)
                {
                    Console.WriteLine("\n Veg Menu ");
                    Console.WriteLine("1. Veg Burger - 100");
                    Console.WriteLine("2. Paneer Pizza - 200");
                    Console.WriteLine("3. Veg Sandwich - 80");
                    Console.WriteLine("4. Pasta - 180");
                    Console.WriteLine("5. French Fries - 90");

                    int choice = InputHelper.GetNumber();

                    switch (choice)
                    {
                        case 1: item = new VegItem("Veg Burger", 100); break;
                        case 2: item = new VegItem("Paneer Pizza", 200); break;
                        case 3: item = new VegItem("Veg Sandwich", 80); break;
                        case 4: item = new VegItem("Pasta", 180); break;
                        case 5: item = new VegItem("French Fries", 90); break;
                        default:
                            Console.WriteLine("Invalid selection! Please choose from 1 to 5.");
                            break;
                    }
                }
                else if (category == (int)FoodCategory.NonVeg)
                {
                    Console.WriteLine("\n Non-Veg Menu ");
                    Console.WriteLine("1. Chicken Burger - 150");
                    Console.WriteLine("2. Chicken Biryani - 250");
                    Console.WriteLine("3. Fried Chicken - 220");
                    Console.WriteLine("4. Egg Roll - 120");
                    Console.WriteLine("5. Fish Curry - 300");

                    int choice = InputHelper.GetNumber();

                    switch (choice)
                    {
                        case 1: item = new NonVegItem("Chicken Burger", 150); break;
                        case 2: item = new NonVegItem("Chicken Biryani", 250); break;
                        case 3: item = new NonVegItem("Fried Chicken", 220); break;
                        case 4: item = new NonVegItem("Egg Roll", 120); break;
                        case 5: item = new NonVegItem("Fish Curry", 300); break;
                        default:
                            Console.WriteLine("Invalid! Please choose from 1 to 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid category! Please select from the given options");
                }

                if (item != null)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = InputHelper.GetNumber();
                    order.AddItem(item, quantity);
                }
            }

            double total = order.CalculateTotal();

            if (total > 0)
            {
                order.PrintOrderDetails();

                BillGenerator bill = new BillGenerator();
                bill.PrintBill(total);

                TotalOrders++;
            }
            else
            {
                Console.WriteLine("No items ordered.");
            }

            Console.WriteLine("\nThank you! Visit Again.");
        }
    }
}

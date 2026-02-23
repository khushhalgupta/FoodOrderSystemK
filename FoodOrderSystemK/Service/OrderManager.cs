using System;
using FoodOrderingSystem.Interface;
using FoodOrder_Library.Models;

namespace FoodOrderingSystem.Service
{
    class OrderManager : IOrder
    {
        private double totalAmount = 0;
        private int totalItems = 0;

        private string[] itemNames = new string[50];
        private int[] quantities = new int[50];
        private double[] itemTotals = new double[50];
        private int index = 0;

        public void AddItem(FoodItem item, int quantity)
        {
            try
            {
                double itemTotal = item.GetPrice(quantity);
                totalAmount += itemTotal;
                totalItems += quantity;

                itemNames[index] = item.GetName();
                quantities[index] = quantity;
                itemTotals[index] = itemTotal;
                index++;

                Console.WriteLine(quantity + " x " + item.GetName() + " added = " + itemTotal);
            }
            catch
            {
                Console.WriteLine("Error while adding item.");
            }
        }

        public double CalculateTotal()
        {
            return totalAmount;
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine("\n Order Summary ");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(itemNames[i] + " | Qty: " + quantities[i] + " | Total: " + itemTotals[i]);
            }

            Console.WriteLine("Total Items: " + totalItems);
        }
    }
}

using System;

namespace FoodOrder_Library.Utilities
{
    public sealed class BillGenerator
    {
        public void PrintBill(double total)
        {
            Console.WriteLine("\n FINAL BILL ");
            Console.WriteLine("Grand Total: " + total);
        }
    }
}

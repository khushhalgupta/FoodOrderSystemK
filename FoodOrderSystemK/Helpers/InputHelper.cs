using System;

namespace FoodOrderingSystem.Helpers
{
    static class InputHelper
    {
        public static int GetNumber()
        {
            try
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Enter number only:");
                }
                return number;
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter number only:");
                return 0;
            }
        }
    }
}

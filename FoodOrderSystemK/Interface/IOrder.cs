using FoodOrder_Library.Models;

namespace FoodOrderingSystem.Interface
{
    interface IOrder
    {
        void AddItem(FoodItem item, int quantity);
        double CalculateTotal();
        void PrintOrderDetails();
    }
}

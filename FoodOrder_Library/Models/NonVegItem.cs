using FoodOrder_Library.Enums;

namespace FoodOrder_Library.Models
{
    public class NonVegItem : FoodItem
    {
        public NonVegItem(string name, double price)
            : base(name, price, FoodCategory.NonVeg) { }
    }
}

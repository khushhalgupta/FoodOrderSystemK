using FoodOrder_Library.Enums;

namespace FoodOrder_Library.Models
{
    public class VegItem : FoodItem
    {
        public VegItem(string name, double price)
            : base(name, price, FoodCategory.Veg) { }
    }
}

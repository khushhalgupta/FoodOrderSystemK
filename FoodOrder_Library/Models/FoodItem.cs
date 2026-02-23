using FoodOrder_Library.Enums;

namespace FoodOrder_Library.Models
{
    public abstract class FoodItem
    {
        protected string Name;
        protected double Price;
        protected FoodCategory Category;

        public FoodItem(string name, double price, FoodCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice(int quantity)
        {
            return Price * quantity;
        }
    }
}

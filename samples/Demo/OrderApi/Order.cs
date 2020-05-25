using System;

namespace OrderApi
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int id, string userName, string foodName)
        {
            ID = id;
            UserName = userName;
            FoodName = foodName;
        }

        public int ID { get; set; }

        public string UserName { get; set; }

        public string FoodName { get; set; }

        public override string ToString()
        {
            return $"{ID}-{UserName}-{FoodName}";
        }
    }
}

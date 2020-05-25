using System;

namespace GoodApi
{
    public class Good
    {
        public Good()
        {

        }

        public Good(int id, string userName, decimal price)
        {
            ID = id;
            GoodName = userName;
            Price = price;
        }

        public int ID { get; set; }

        public string GoodName { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ID}-{GoodName}-{Price}";
        }
    }
}

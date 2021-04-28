using System;


namespace MyCoffeeProject
{
     public abstract class CoffeeDrinks
    {
        public string size { get; set; }
        public string brewTime { get; set; }
        public double price { get; set; }
        protected const double STOREFEE = .05;

        protected double retailPrice;

        public double RetailPrice
        {
            set { calcPrice(); }
            get { return retailPrice; }
        }
        public void calcPrice()
        {
            RetailPrice = (price * STOREFEE);
        }

    }

    class HotCoffee : CoffeeDrinks
    {
  
        public HotCoffee(string siz, string brewTi, double pric)
        {
            size = siz;
            brewTime = brewTi;           
            price = pric;
        }
    }
    class HotLatte : CoffeeDrinks
    {
        public string MilkAmount { get; set; }

        public HotLatte(string siz, string brewTi, double pric)
        {
            size = siz;
            brewTime = brewTi;
            price = pric;
        }
    }
}

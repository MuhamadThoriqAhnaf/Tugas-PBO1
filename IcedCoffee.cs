using System;

namespace MyCoffeeProject
{
    class IcedCoffee : CoffeeDrinks
    {
        public string iceAmount { get; set; }

        public IcedCoffee(string siz, string brewTi, string iceAmt, double pric)
        {
            size = siz;
            brewTime = brewTi;
            iceAmount = iceAmt;
            price = pric ;
        }
    }
}

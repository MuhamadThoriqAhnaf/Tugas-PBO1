using System;

namespace MyCoffeeProject
{
    class IcedLatte : CoffeeDrinks
    {
        public string IceAmount { get; set; }
        public string MilkAmount { get; set; }

        public IcedLatte(string siz, string brewTi, string iceAmt, string milkA, double pric)
        {
            size = siz;
            brewTime = brewTi;
            IceAmount = iceAmt;
            MilkAmount = milkA;
            price = pric;
        }
    }
}

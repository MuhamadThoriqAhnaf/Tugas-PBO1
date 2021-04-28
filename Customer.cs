using System;


namespace MyCoffeeProject
{
    class Customer
    {
        
        public string Firstname { get; set; }
        private string _favCoffee;

        public string FavCoffee
        {
            get
            {
                return _favCoffee;
            }

            set
            {
                _favCoffee = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }

        private int _custId;

        //set
        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID cant be negative number");
            }
            //set
            this._custId = id;
        }

        //get
        public int getId()
        {
            return this._custId;
        }

        private int _test;
                public  const double FEE = .3;

        public Customer( string name,  string phone, string fCoffee)
        {
            Firstname = name;
            _favCoffee = fCoffee;
            PhoneNumber = phone;
        }
        public string DisplayCustomer()
        {
            return this.Firstname + " " + " " + " Phone Number: " + this.phoneNumber + Environment.NewLine + "Favorite Coffee: " + this._favCoffee;
        }
        public string GetFullName()
        {
            return this.Firstname + " " ;
        }
        public double getFee()
        {
            return FEE;
        }
    }
}

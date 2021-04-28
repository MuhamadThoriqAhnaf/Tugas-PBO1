using System;
using System.Data.SqlClient;
namespace MyCoffeeProject
{
    class Program
    {
        static string connectionString = "SERVER = DESKTOP-P0UJKQB; DATABASE = LOGIN; USER ID = COBA; PASSWORD = RANGERTI123"
        static void Main(string[] args)
        {
            using (sqlconn)
            {
                    sqlconn.open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE NAME =@Username AND PASSWORD = @Password", sqlconn);
                    cmd.Parameters.AddWithValue("@Username", "THORIQ");
                    cmd.Parameters.AddWithValue("@Password", "ASDFGH");
                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                     {
                    Console.WriteLine("Login Sukses")
                    Console.WriteLine("Masukkan Nama anda");
                    string Firstname = Console.ReadLine();
                    Console.WriteLine("Masukkan No telpon anda");
                    string PhoneNumber = Console.ReadLine();
                    Console.WriteLine("IcedCoffee atau IcedLatte");
                    string fCoffee = Console.ReadLine();
                    Customer custom = new Customer(Firstname, PhoneNumber, fCoffee);
                    Console.WriteLine("Small Medium Large ");
                    string size = Console.ReadLine();
                    Console.WriteLine("Jumlah : ");
                    int Jumlah = Convert.ToInt32(Console.ReadLine());
                }
                static void cafe(string size, string fCoffee, int Jumlah)
                {

                    string coffe = fCoffee;

                    if (coffe == "IcedCoffee")
                    {
                        string bTime = "long";
                        string iceamt = "normal";
                        if (size == "small")
                        {
                            size = "Small";
                        }
                        else if (size == "medium")
                        {
                            size = "Medium";
                        }
                        else
                        {
                            size = "Large";
                        }
                        IcedCoffee custsCoffee = new IcedCoffee(size, bTime, iceamt, 35);
                        Console.WriteLine(custsCoffee);
                        Console.WriteLine("Price: " + custsCoffee.price * Jumlah);
                    }
                    else if (coffe == "IcedLatte")
                    {
                        string bTime = "short";
                        string icea = "normal";
                        string milkAmount = "normal";

                        if (size == "small")
                        {
                            size = "Small";
                        }
                        else if (size == "medium")
                        {
                            size = "Medium";
                        }
                        else
                        {
                            size = "Large";
                        }

                        IcedLatte custsCoffee = new IcedLatte(size, bTime, icea, milkAmount, 50);
                        Console.WriteLine(custsCoffee);
                        double price = custsCoffee.price;
                        Console.WriteLine("Price: " + price * Jumlah);
                    }
                    else
                    {
                        Console.WriteLine("Login Gagal");
                    }
                }
            }

            }
        }
    }


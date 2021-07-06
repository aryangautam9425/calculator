using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        public void OrderDetails(string SellerName, string ProductName, int Quantity = 1, bool Returnable = true)
        {
            Console.WriteLine("Here is the order detail – {0} number of {1} by {2} is ordered. It’s returnable status is {3}\n", Quantity, ProductName, SellerName, Returnable);
        }

        static void Main(string[] args)
        {

            Program optinal = new Program();
            optinal.OrderDetails("Amazon", "Realme Mobile");
            optinal.OrderDetails("Amazon", "Realme Mobile", 6, false);
            Console.ReadLine();

        }
    }
}


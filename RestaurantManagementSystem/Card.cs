using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Card : Discount
    {
        public void getDiscount(int num)
        {
            Console.WriteLine("Pay by Card - 20% discount");
            Console.WriteLine(num * 0.8);
        }
    }
}

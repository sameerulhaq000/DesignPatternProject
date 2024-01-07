using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Cash : Discount
    {
        public void getDiscount(int num)
        {
            Console.WriteLine("Pay by Cash");
            Console.WriteLine(num);
        }
    }
}

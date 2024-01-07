using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Pepsi : Food
    {
        public void getName()
        {
            Console.WriteLine("This is Pepsi");
        }
        public int getPrice()
        {
            return 50;
        }
    }
}

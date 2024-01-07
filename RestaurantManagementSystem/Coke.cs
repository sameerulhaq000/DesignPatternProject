using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Coke : Food
    {
        public void getName()
        {
            Console.WriteLine("This is Coke");
        }
        public int getPrice()
        {
            return 40;
        }
    }
}

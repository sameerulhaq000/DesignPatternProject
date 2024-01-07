using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class VegBurger : Food
    {
        public void getName()
        {
            Console.WriteLine("This is Veg Burger");
        }
        public int getPrice()
        {
            return 100;
        }
    }
}

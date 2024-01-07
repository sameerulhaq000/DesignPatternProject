using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class ChickenBurger : Food
    {
        public void getName()
        {
            Console.WriteLine("This is Chicken Burger");
        }
        public int getPrice()
        {
            return 200;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class FoodFactory
    {
        public Food getFood(string name)
        {
            if (name == "Chicken Burger")
            {
                return new ChickenBurger();
            }
            else if (name == "Veg Burger")
            {
                return new VegBurger();
            }
            else if (name == "Coke")
            {
                return new Coke();
            }
            else
            {
                return new Pepsi();
            }
        }
    }
}

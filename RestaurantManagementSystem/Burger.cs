using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantManagementSystem
{
    public abstract class Burger : Item
    {
        public abstract string getName();
        public abstract int getPrice();
        public Packing getPack()
        {
            return new Wrapper();
        }
    }
}

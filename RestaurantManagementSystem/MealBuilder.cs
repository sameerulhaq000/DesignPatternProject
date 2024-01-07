using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class MealBuilder
    {
        public Meal Deal1()
        {
            Meal m = new Meal();
            m.addItem(new Coke());
            m.addItem(new ChickenBurger());
            return m;
        }
        public Meal Deal2()
        {
            Meal m = new Meal();
            m.addItem(new Pepsi());
            m.addItem(new VegBurger());
            return m;
        }
    }
}

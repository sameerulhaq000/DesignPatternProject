using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Meal
    {
        public List<Food> items = new List<Food>();

        public void addItem(Food i)
        {
            items.Add(i);
        }
        public void print()
        {
            foreach (Food item in items)
            {
                item.getName();
            }
        }
    }
}

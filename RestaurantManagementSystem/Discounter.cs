using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Discounter
    {
        private Discount discount;

        public void setDiscount(Discount d)
        {
            discount = d;
        }
        public void operate(int num)
        {
            discount.getDiscount(num);
        }
    }

}

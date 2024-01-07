using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class VendorFactory
    {
        public Vendor getVendor(string name)
        {
            if (name == "Manufacturers")
            {
                return new Manufacturers();
            }
            else if (name == "Retailers")
            {
                return new Retailers();
            }
            else if (name == "Wholesalers")
            {
                return new Wholesalers();
            }
            else
            {
                return new Service();
            }
        }
    }
}
